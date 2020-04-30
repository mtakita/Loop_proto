using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeComponent : MonoBehaviour
{
    int nodeIndex;
    bool tobeDestroyFlg;

    Rigidbody2D rb;
    Loop loop;

    bool mouseDownFlg;
    Vector2 offset;

    LoopComponent loopComponent;

    bool invalidatedPositionFlag;

    public void SetLoop( Loop inLoop)
    {
        loop = inLoop;
    }

    public void SetNodeIndex( int inNodeIndex )
    {
        nodeIndex = inNodeIndex;
    }

    public int GetNodeIndex()
    {
        return nodeIndex;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tobeDestroyFlg = false;

        // 何かましな方法はないか?
        GameObject loopGameObject = GameObject.Find("Loop(Clone)");
        loopComponent = loopGameObject.GetComponent<LoopComponent>();

        invalidatedPositionFlag = false;
    }

    public void InvalidateNodeComponentPosition()
    {
        invalidatedPositionFlag = true;
    }

    void RetrievePosition()
    {
        switch(loop.GetNode(nodeIndex).GetStatus())
        {
            case Node.enum_status.pre_spawn:

                Vector2 pos = loop.GetNode(nodeIndex).GetScreenPos();

                transform.position = pos;

                break;

        }
    }

    void StorePosition()
    {
        Vector2 pos = transform.position;
        loop.GetNode(nodeIndex).SetScreenPos(pos);
    }

    // Update is called once per frame
    void Update()
    {
        if (invalidatedPositionFlag == true)
        {
            // retrieve new position from node internal data structure to gameobject.
            RetrievePosition();

            invalidatedPositionFlag = false;

            return;
        }
        else
        {
            // store new position from gameobject into node internal data structure.
            StorePosition();
            loop.IterateEdge(nodeIndex);
        }

        if (mouseDownFlg == false)
        {
            return;
        }

        if ( loop.GetNode(nodeIndex).GetStatus() != Node.enum_status.idle)
        {
            // pre-spawning in progress.
            return;
        }

        //        Vector3 curMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 curMousePos = Camera.main.ScreenToWorldPoint( Input.mousePosition );
        curMousePos = curMousePos + new Vector3( offset.x, offset.y, curMousePos.z );

        Vector3 transPos = transform.position;
        transPos = new Vector3(curMousePos.x, curMousePos.y, transform.position.z );
        transform.position = transPos;

        loop.UpdateNodePosition(transPos, nodeIndex );
        loop.IterateEdge(nodeIndex);
    }

    void OnMouseDown()
    {
        mouseDownFlg = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint( Input.mousePosition );
    }

    private void OnMouseUp()
    {
        mouseDownFlg = false;
    }

    void SetToBeDestroyFlg()
    {
        tobeDestroyFlg = true;
    }

    bool GetToBeDestroyFlg()
    {
        return tobeDestroyFlg;
    }

    public void UpdateEdge(float x, float y, int rightNodeIndex, int leftNodeIndex, List<Node> inNodes, GameObject edgePrefab)
    {
        Transform tr;
        LineRenderer lr;

        tr = edgePrefab.gameObject.GetComponent<Transform>();
        tr.position = new Vector3(x, y, 0.0f);

        lr = edgePrefab.GetComponent<LineRenderer>();
        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;

        Vector3 rightPos = new Vector3(inNodes[rightNodeIndex].GetXPos(), inNodes[rightNodeIndex].GetYPos(), 0);
        lr.SetPosition(0, rightPos);

        Vector3 leftPos = new Vector3(inNodes[leftNodeIndex].GetXPos(), inNodes[leftNodeIndex].GetYPos(), 0);
        lr.SetPosition(1, leftPos);

    }

    public void UpdateNode( int inNodeIndex, GameObject inNodePrefab)
    {
        NodeComponent nodeComponent = inNodePrefab.gameObject.GetComponent<NodeComponent>();
        nodeComponent.SetNodeIndex(inNodeIndex);
    }

    bool canCollide(Collision2D collision)
    {
        GameObject loopEnter = GameObject.Find("LoopEnter(Clone)");
        if( loopEnter != null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    void DestroyNode( GameObject inGameObject, float inWithin )
    {
        CircleCollider2D collider2d = inGameObject.GetComponent<CircleCollider2D>();
        Destroy(collider2d, inWithin);

        Rigidbody2D rigidbody2d = inGameObject.GetComponent<Rigidbody2D>();
        Destroy(rigidbody2d, inWithin);

        NodeComponent nodeComponent = inGameObject.GetComponent<NodeComponent>();
        nodeComponent.SetNodeIndex(-1);
        Destroy(nodeComponent, inWithin);

        Destroy(inGameObject, 0.0f );

    }

    bool isStillAlive(GameObject inGameObject, Collision2D collision)
    {
        NodeComponent nodeComponent = inGameObject.GetComponent<NodeComponent>();
        NodeComponent nodeComponentOther = collision.gameObject.GetComponent<NodeComponent>();

        if ( nodeComponent.GetNodeIndex() != -1 && nodeComponentOther.GetNodeIndex() != -1 )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // check gameobject is still alive.
        if( false == isStillAlive(gameObject, collision ))
        {
            return;
        }

        //
        // if tobeDestroyFlg is set, there is no more process to do.
        //
        if (GetToBeDestroyFlg() == true)
        {
            DestroyNode(gameObject,0);

            // update new edges after destroying the node.
            loop.IterateEdgeForUpdatePrefab(UpdateEdge);

//            if (checkPrefabNodeHasUniqueNodeIndex() == false)
 //           {
  //              Application.Quit();
   //         }

            return;
        }

        //
        // if both either of node is pre-spawn, collision cannot be executed.
        //
        
        if( canCollide( collision ) == false)
        {
            return;
        }
        

        //
        // Combine 2 nodes and tell the other node to be destroyed.
        //

        Vector2 middlePos = (collision.transform.position + transform.position) / 2.0f;
        transform.position = middlePos;

        NodeComponent otherNode = collision.gameObject.GetComponent<NodeComponent>();
        int otherIndex = otherNode.GetNodeIndex();


        // debug
 //       int upperBound = loop.edges.GetUpperBound(0);
  //      if (loop.nodes.Count != loop.numOfNodes || (upperBound+1) != loop.numOfDimension)
   //     {
    //        Application.Quit();
     //   }
      //  if( nodeIndex == (upperBound+1))
       // {
        //    Application.Quit();
        //}


        // delete the disappear edge if any.
        Edge edge = loop.GetEdge(nodeIndex, otherIndex);
        if (edge != null )
        {
                Destroy(edge.GetEdgePrefab(), 0);
        }


        // combine 2 nodes.(actually delete both and craete new one.)
        List<Edge> outEdgesMerge = new List<Edge>();
        int newNodeIndex = loop.combineNodes(nodeIndex, otherIndex, middlePos, outEdgesMerge);
//        Debug.Log("deleted node indecies : " + nodeIndex + "," + otherIndex);

//        DebugOutNumberOfNodeAndEdge();

        // create new one.
        Node newNode = loop.GetNode(newNodeIndex);
        Vector2 pos = new Vector2(newNode.GetXPos(), newNode.GetYPos());
        GameObject nodePrefab = loopComponent.CreateNode(pos, newNodeIndex);
        newNode.SetNodePrefab(nodePrefab);

        // delete disappear edges.
        for( int i = 0; i < outEdgesMerge.Count; i++)
        {
            Destroy(outEdgesMerge[i].GetEdgePrefab(), 0.0f );
        }


        // tell the other node that these two nodes area dead.
        otherNode.SetToBeDestroyFlg();


        // destroy myself.
        DestroyNode(this.gameObject, 0);

        // destroy the other.
        DestroyNode(collision.gameObject, 0);



    }


    //
    // Entire methods after this line are not necessary for executing program, but just for debugging purpose.
    //

    bool checkPrefabNodeHasUniqueNodeIndex()
    {
        GameObject[] nodeInstances = GameObject.FindGameObjectsWithTag("node");

        for( int i = 0; i < nodeInstances.Length-1; i++)
        {
            for( int j = i + 1; j < nodeInstances.Length; j++)
            {
                NodeComponent nodeComponent1 = nodeInstances[i].GetComponent<NodeComponent>();
                NodeComponent nodeComponent2 = nodeInstances[j].GetComponent<NodeComponent>();
                int nodeIndex1 = nodeComponent1.GetNodeIndex();
                int nodeIndex2 = nodeComponent2.GetNodeIndex();

                if( nodeIndex1 == nodeIndex2)
                {
                    return false;
                }
            }
        }

        return true;

    }


    void DebugOut()
    {
        Debug.Log("deleted Nodex index = " + nodeIndex);

        Debug.Log("remaining node indecies: number of indices = " + loop.nodes.Count );

        string indecies = "";
        foreach ( Node node in loop.nodes)
        {
            indecies = indecies + "," + node.getNodeIndex();
        }

        Debug.Log( indecies + "\n" );





        GameObject[] nodeInstances = GameObject.FindGameObjectsWithTag("node");
        Debug.Log("remaining node instance indecies: number of indices = " + nodeInstances.Length );
        indecies = "";
        foreach ( GameObject gameObject in nodeInstances)
        {
            if( gameObject == null)
            {
                NodeComponent nodeComponent = gameObject.GetComponent<NodeComponent>();
                indecies = indecies + "," + nodeComponent.GetNodeIndex() + "(null)";
            }
            else
            {
                NodeComponent nodeComponent = gameObject.GetComponent<NodeComponent>();
                indecies = indecies + "," + nodeComponent.GetNodeIndex();
            }
        }

        Debug.Log(indecies + "\n");




        Debug.Log("remaining edge indecies: number of indices = " + loop.edges.Length);

        indecies = "";
        foreach (Edge edge in loop.edges)
        {
            if (edge == null)
            {
                continue;
            }

            int leftNodeIndex = edge.GetLeftNodeIndex();
            int rightNodeIndex = edge.GetRightNodeIndex();

            indecies = indecies + ",(" + leftNodeIndex + "," + rightNodeIndex + ")";
        }

        Debug.Log(indecies + "\n");


    }

    void DebugLogGameObjectBeforeDestroy( GameObject inGameObject)
    {
        int instanceId = inGameObject.GetInstanceID();

        Debug.Log(instanceId + " will be deleted.");


    }


    void DebugOutNumberOfNodeAndEdge()
    {
        int numOfNode = loop.nodes.Count;
        int numOfEdge = loop.edges.Length;

        Debug.Log("(nodes.Count, edges.Length) = (" + numOfNode + "," + numOfEdge + ")\n");

        numOfNode = loop.numOfNodes;
        numOfEdge = loop.numOfDimension;

        Debug.Log("(numOfNodes, numOfDimension) = (" + numOfNode + "," + numOfEdge + ")\n");

    }



}

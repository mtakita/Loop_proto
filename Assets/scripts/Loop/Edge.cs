using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge
{
//    bool activated;
    int rightNodeIndex;
    int leftNodeIndex;

    GameObject edgePrefab;

    List<GameObject> nodes;

    public Edge( int inRightNodeIndex, int inLeftNodeIndex)
    {
        rightNodeIndex = inRightNodeIndex;
        leftNodeIndex = inLeftNodeIndex;
    }

    public void SetEdgePrefab( GameObject inEdgePrefab)
    {
        edgePrefab = inEdgePrefab;
    }

    public GameObject GetEdgePrefab()
    {
        return edgePrefab;
    }

    public void UpdatePos(float x, float y, int rightNodeIndex, int leftNodeIndex, List<Node> inNodes)
    {
        Transform tr;
        LineRenderer lr;

        tr = edgePrefab.GetComponent<Transform>();
        tr.position = new Vector3(x, y, 0.0f);

        lr = edgePrefab.GetComponent<LineRenderer>();
        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;

        Vector3 rightPos = new Vector3(inNodes[rightNodeIndex].GetXPos(), inNodes[rightNodeIndex].GetYPos(), 0);
        lr.SetPosition(0, rightPos);

        Vector3 leftPos = new Vector3(inNodes[leftNodeIndex].GetXPos(), inNodes[leftNodeIndex].GetYPos(), 0);
        lr.SetPosition(1, leftPos);

    }

    public void SetNodesRef(List<GameObject> inNodes )
    {
        nodes = inNodes;
    }

    public int GetRightNodeIndex()
    {
        return rightNodeIndex;
    }

    public int GetLeftNodeIndex()
    {
        return leftNodeIndex;
    }

    public void SetRightNodeIndex( int inRightNodeIndex )
    {
        rightNodeIndex = inRightNodeIndex;
    }

    public void SetLeftNodeIndex( int inLeftNodeIndex )
    {
        leftNodeIndex = inLeftNodeIndex;
    }
/*
    public bool isActive()
    {
        return activated;
    }

    public void activate()
    {
        activated = true;
    }

    public void deactivate()
    {
        activated = false;
    }
*/
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

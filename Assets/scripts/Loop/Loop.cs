using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loop
{

//    Node[] nodes;
    public List<Node> nodes;
    public int numOfNodes;

    public Edge[,] edges;
    public int numOfDimension;
    Link link;

    public delegate GameObject SpawnNode(float x, float y, int number, int nodeIndex, SpawnInfo inSpawnInfo );
    public delegate GameObject AddNode(float x, float y, int number,int nodeIndex );
    public delegate GameObject AddEdge(float x, float y, int rightNodeIndex, int leftNodeIndex, List<Node> nodes);
    public delegate void UpdateEdge( float x, float y, int rightNodeIndex, int leftNodeIndex, List<Node> inNodes, GameObject edgePrefab);
    public delegate void UpdateNode(int nodeIndex, GameObject nodePrefab );

    public Loop()
    {
        // clear
        for (int i = 0; i < numOfNodes; i++)
        {
            nodes[i] = null;
        }

        nodes = new List<Node>();
        numOfNodes = 0;

        edges = new Edge[0,0];
        numOfDimension = 0;
    }

/*
    public Loop(type_loop typeLoop)
    {
        // clear
        for (int i = 0; i < numOfNodes; i++)
        {
            nodes[i] = null;
        }

        numOfNodes = 0;

        switch (typeLoop)
        {
            case type_loop.one:
                generateOne();
                break;
            case type_loop.two:
                generateTwo();
                break;
            case type_loop.three:
                generateThree();
                break;
            case type_loop.four:
                generateFour();
                break;
            case type_loop.five:
                generateFive();
                break;
            case type_loop.six:
                generateSix();
                break;
            case type_loop.random:
                generateRandom();
                break;
        }
    }
*/
/*
    public void AddEdgesNodesOne(List<Node> outAddedNode, List<Edge> outAddedEdge)
    {
        //
        // Add a node.
        //

        int newNodeIndex = nodes.Count;
        Node newNode = new Node(newNodeIndex, new Vector2(0.0f, 2.0f) );
        nodes.Add(newNode);
        numOfNodes++;

        AddEdgesSpawn1Node0Edge(outAddedEdge);

        outAddedNode.Add(newNode);

    }

    public void AddEdgesNodesTwo(List<Node> outAddedNode, List<Edge> outAddedEdge)
    {
        //
        // Add two node.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex, new Vector2(-1.0f, 0.0f));
        Node newNode2 = new Node(newNodeIndex+1, new Vector2(+1.0f, 0.0f));
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        numOfNodes += 2;

        AddEdgesSpawn3Node3Edge(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
    }

    public void AddEdgesNodesThree(List<Node> outAddedNode, List<Edge> outAddedEdge)
    {
        //
        // Add three node.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex    , new Vector2( 0.0f, -0.5f));
        Node newNode2 = new Node(newNodeIndex + 1, new Vector2( 1.0f,  0.5f));
        Node newNode3 = new Node(newNodeIndex + 2, new Vector2(-1.0f,  0.5f));
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        nodes.Add(newNode3);
        numOfNodes += 3;

        AddEdgesThree(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
        outAddedNode.Add(newNode3);
    }

    public void AddEdgesNodesFour(List<Node> outAddedNode, List<Edge> outAddedEdge)
    {
        //
        // Add four node.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex, new Vector2(-1.0f, -1.0f));
        Node newNode2 = new Node(newNodeIndex + 1, new Vector2(-1.0f, +1.0f));
        Node newNode3 = new Node(newNodeIndex + 2, new Vector2(+1.0f, +1.0f));
        Node newNode4 = new Node(newNodeIndex + 3, new Vector2(+1.0f, -1.0f));
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        nodes.Add(newNode3);
        nodes.Add(newNode4);
        numOfNodes += 4;

        AddEdgesFour(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
        outAddedNode.Add(newNode3);
        outAddedNode.Add(newNode4);
    }

    public void AddEdgesNodesFive(List<Node> outAddedNode, List<Edge> outAddedEdge)
    {
        //
        // Add four node.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex    , new Vector2(-1.0f, -1.0f));
        Node newNode2 = new Node(newNodeIndex + 1, new Vector2(-1.0f, +1.0f));
        Node newNode3 = new Node(newNodeIndex + 2, new Vector2(+1.0f, +1.0f));
        Node newNode4 = new Node(newNodeIndex + 3, new Vector2(+1.0f, -1.0f));
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        nodes.Add(newNode3);
        nodes.Add(newNode4);
        numOfNodes += 4;

        AddEdgesFive(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
        outAddedNode.Add(newNode3);
        outAddedNode.Add(newNode4);
    }

    public void AddEdgesNodesSix(List<Node> outAddedNode, List<Edge> outAddedEdge)
    {
        //
        // Add four node.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex, new Vector2(-1.0f, -1.0f));
        Node newNode2 = new Node(newNodeIndex + 1, new Vector2(-1.0f, +1.0f));
        Node newNode3 = new Node(newNodeIndex + 2, new Vector2(+1.0f, +1.0f));
        Node newNode4 = new Node(newNodeIndex + 3, new Vector2(+1.0f, -1.0f));
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        nodes.Add(newNode3);
        nodes.Add(newNode4);
        numOfNodes += 4;

        AddEdgesSix(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
        outAddedNode.Add(newNode3);
        outAddedNode.Add(newNode4);
    }
*/
    void AddEdgesSpawn1Node0Edge(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for( int row = 0; row < numOfNodes-1; row++)
        {
            for( int column = 0; column < numOfNodes - 1; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        numOfDimension += 1;

        // replacing with new edges.
        edges = newEdges;

    }

    void AddEdgesSpawn2Node1Edge( List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 2; row++)
        {
            for (int column = 0; column < numOfNodes - 2; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge = new Edge(numOfNodes - 2, numOfNodes - 1);
        newEdges[numOfNodes - 2, numOfNodes-1] = newEdge;

        numOfDimension += 2;

        outAddedEdge.Add(newEdge);

        // replacing with new edges.
        edges = newEdges;

    }

    
    void AddEdgesSpawn3Node3Edge(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 3; row++)
        {
            for (int column = 0; column < numOfNodes - 3; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge1 = new Edge(numOfNodes - 3, numOfNodes - 2);
        newEdges[numOfNodes - 3, numOfNodes - 2] = newEdge1;
        Edge newEdge2 = new Edge(numOfNodes - 3, numOfNodes - 1);
        newEdges[numOfNodes - 3, numOfNodes - 1] = newEdge2;
        Edge newEdge3 = new Edge(numOfNodes - 2, numOfNodes - 1);
        newEdges[numOfNodes - 2, numOfNodes - 1] = newEdge3;

        numOfDimension += 3;

        outAddedEdge.Add(newEdge1);
        outAddedEdge.Add(newEdge2);
        outAddedEdge.Add(newEdge3);

        // replacing with new edges.
        edges = newEdges;

    }

    void AddEdgesSpawn3Node2Edge(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 3; row++)
        {
            for (int column = 0; column < numOfNodes - 3; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge1 = new Edge(numOfNodes - 3, numOfNodes - 2);
        newEdges[numOfNodes - 3, numOfNodes - 2] = newEdge1;
        Edge newEdge2 = new Edge(numOfNodes - 3, numOfNodes - 1);
        newEdges[numOfNodes - 3, numOfNodes - 1] = newEdge2;

        numOfDimension += 3;

        outAddedEdge.Add(newEdge1);
        outAddedEdge.Add(newEdge2);

        // replacing with new edges.
        edges = newEdges;

    }

    void AddEdgesSpawn4Node4Edge(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 4; row++)
        {
            for (int column = 0; column < numOfNodes - 4; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge1 = new Edge(numOfNodes - 4, numOfNodes - 3);
        newEdges[numOfNodes - 4, numOfNodes - 3] = newEdge1;
        Edge newEdge2 = new Edge(numOfNodes - 4, numOfNodes - 1);
        newEdges[numOfNodes - 4, numOfNodes - 1] = newEdge2;
        Edge newEdge3 = new Edge(numOfNodes - 3, numOfNodes - 2);
        newEdges[numOfNodes - 3, numOfNodes - 2] = newEdge3;
        Edge newEdge4 = new Edge(numOfNodes - 2, numOfNodes - 1);
        newEdges[numOfNodes - 2, numOfNodes - 1] = newEdge4;

        numOfDimension += 4;

        outAddedEdge.Add(newEdge1);
        outAddedEdge.Add(newEdge2);
        outAddedEdge.Add(newEdge3);
        outAddedEdge.Add(newEdge4);

        // replacing with new edges.
        edges = newEdges;

    }

    void AddEdgesSpawn4Node3Edge(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 4; row++)
        {
            for (int column = 0; column < numOfNodes - 4; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge1 = new Edge(numOfNodes - 4, numOfNodes - 3);
        newEdges[numOfNodes - 4, numOfNodes - 3] = newEdge1;
        Edge newEdge2 = new Edge(numOfNodes - 4, numOfNodes - 2);
        newEdges[numOfNodes - 4, numOfNodes - 2] = newEdge2;
        Edge newEdge3 = new Edge(numOfNodes - 4, numOfNodes - 1);
        newEdges[numOfNodes - 4, numOfNodes - 1] = newEdge3;

        numOfDimension += 4;

        outAddedEdge.Add(newEdge1);
        outAddedEdge.Add(newEdge2);
        outAddedEdge.Add(newEdge3);

        // replacing with new edges.
        edges = newEdges;

    }

    void AddEdgesSpawn4Node5Edge(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 4; row++)
        {
            for (int column = 0; column < numOfNodes - 4; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge1 = new Edge(numOfNodes - 4, numOfNodes - 3);
        newEdges[numOfNodes - 4, numOfNodes - 3] = newEdge1;
        Edge newEdge2 = new Edge(numOfNodes - 4, numOfNodes - 2);
        newEdges[numOfNodes - 4, numOfNodes - 2] = newEdge2;
        Edge newEdge3 = new Edge(numOfNodes - 4, numOfNodes - 1);
        newEdges[numOfNodes - 4, numOfNodes - 1] = newEdge3;
        Edge newEdge4 = new Edge(numOfNodes - 3, numOfNodes - 2);
        newEdges[numOfNodes - 3, numOfNodes - 2] = newEdge4;
        Edge newEdge5 = new Edge(numOfNodes - 2, numOfNodes - 1);
        newEdges[numOfNodes - 2, numOfNodes - 1] = newEdge5;

        numOfDimension += 4;

        outAddedEdge.Add(newEdge1);
        outAddedEdge.Add(newEdge2);
        outAddedEdge.Add(newEdge3);
        outAddedEdge.Add(newEdge4);
        outAddedEdge.Add(newEdge5);

        // replacing with new edges.
        edges = newEdges;

    }

    void AddEdgesThree(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 3; row++)
        {
            for (int column = 0; column < numOfNodes - 3; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge1 = new Edge(numOfNodes - 3, numOfNodes - 2);
        newEdges[numOfNodes - 3, numOfNodes - 2] = newEdge1;

        Edge newEdge2 = new Edge(numOfNodes - 3, numOfNodes - 1);
        newEdges[numOfNodes - 3, numOfNodes - 1] = newEdge2;

        Edge newEdge3 = new Edge(numOfNodes - 2, numOfNodes - 1);
        newEdges[numOfNodes - 2, numOfNodes - 1] = newEdge3;


        numOfDimension += 3;

        outAddedEdge.Add(newEdge1);
        outAddedEdge.Add(newEdge2);
        outAddedEdge.Add(newEdge3);

        // replacing with new edges.
        edges = newEdges;

    }

    void AddEdgesFour(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 4; row++)
        {
            for (int column = 0; column < numOfNodes - 4; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge1 = new Edge(numOfNodes - 4, numOfNodes - 3);
        newEdges[numOfNodes - 4, numOfNodes - 3] = newEdge1;

        Edge newEdge2 = new Edge(numOfNodes - 4, numOfNodes - 1);
        newEdges[numOfNodes - 4, numOfNodes - 1] = newEdge2;

        Edge newEdge3 = new Edge(numOfNodes - 4, numOfNodes - 2);
        newEdges[numOfNodes - 4, numOfNodes - 2] = newEdge3;

        numOfDimension += 4;

        outAddedEdge.Add(newEdge1);
        outAddedEdge.Add(newEdge2);
        outAddedEdge.Add(newEdge3);

        // replacing with new edges.
        edges = newEdges;

    }
    void AddEdgesFive(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 4; row++)
        {
            for (int column = 0; column < numOfNodes - 4; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge1 = new Edge(numOfNodes - 4, numOfNodes - 3);
        newEdges[numOfNodes - 4, numOfNodes - 3] = newEdge1;

        Edge newEdge2 = new Edge(numOfNodes - 4, numOfNodes - 1);
        newEdges[numOfNodes - 4, numOfNodes - 1] = newEdge2;

        Edge newEdge3 = new Edge(numOfNodes - 3, numOfNodes - 2);
        newEdges[numOfNodes - 3, numOfNodes - 2] = newEdge3;

        Edge newEdge4 = new Edge(numOfNodes - 2, numOfNodes - 1);
        newEdges[numOfNodes - 2, numOfNodes - 1] = newEdge4;

        numOfDimension += 4;

        outAddedEdge.Add(newEdge1);
        outAddedEdge.Add(newEdge2);
        outAddedEdge.Add(newEdge3);
        outAddedEdge.Add(newEdge4);

        // replacing with new edges.
        edges = newEdges;

    }

    void AddEdgesSix(List<Edge> outAddedEdge)
    {
        Edge[,] newEdges = new Edge[numOfNodes, numOfNodes];

        // copy all edges present in the previous edges.
        for (int row = 0; row < numOfNodes - 4; row++)
        {
            for (int column = 0; column < numOfNodes - 4; column++)
            {
                newEdges[row, column] = edges[row, column];

            }
        }

        Edge newEdge1 = new Edge(numOfNodes - 4, numOfNodes - 3);
        newEdges[numOfNodes - 4, numOfNodes - 3] = newEdge1;

        Edge newEdge2 = new Edge(numOfNodes - 4, numOfNodes - 1);
        newEdges[numOfNodes - 4, numOfNodes - 1] = newEdge2;

        Edge newEdge3 = new Edge(numOfNodes - 3, numOfNodes - 2);
        newEdges[numOfNodes - 3, numOfNodes - 2] = newEdge3;

        Edge newEdge4 = new Edge(numOfNodes - 2, numOfNodes - 1);
        newEdges[numOfNodes - 2, numOfNodes - 1] = newEdge4;

        Edge newEdge5 = new Edge(numOfNodes - 4, numOfNodes - 2);
        newEdges[numOfNodes - 4, numOfNodes - 2] = newEdge5;

        numOfDimension += 4;

        outAddedEdge.Add(newEdge1);
        outAddedEdge.Add(newEdge2);
        outAddedEdge.Add(newEdge3);
        outAddedEdge.Add(newEdge4);
        outAddedEdge.Add(newEdge5);

        // replacing with new edges.
        edges = newEdges;

    }



    public void IterateNodeSpawn(List<Node> inAddedNode, SpawnNode myMethodName, SpawnInfo inSpawnInfo )
    {
        float x;
        float y;
        int nodeIndex;
        int nodeValue;

        foreach (Node node in inAddedNode)
        {
            Vector2 pos = node.GetScreenPos();

            x = pos.x;
            y = pos.y;
            nodeIndex = node.getNodeIndex();
            nodeValue = node.getNodeValue();

            GameObject nodePrefab = myMethodName(x, y, nodeValue, nodeIndex, inSpawnInfo );
            node.SetNodePrefab(nodePrefab);
        }
    }

    public void IterateNode(List<Node> inAddedNode, AddNode myMethodName)
    {
        int number = 1;
        float x;
        float y;
        int nodeIndex;

        foreach (Node node in inAddedNode)
        {
            Vector2 pos = node.GetScreenPos();

            x = pos.x;
            y = pos.y;
            nodeIndex = node.getNodeIndex();

            GameObject nodePrefab = myMethodName(x, y, number++, nodeIndex);
            node.SetNodePrefab(nodePrefab);
        }
    }

    public void IterateNode(AddNode myMethodName)
    {
        int number = 1;
        float x;
        float y;
        int nodeIndex;

        foreach( Node node in nodes )
        {
            Vector2 pos = node.GetScreenPos();

            x = pos.x;
            y = pos.y;
            nodeIndex = node.getNodeIndex();

            GameObject nodePrefab = myMethodName(x, y, number++, nodeIndex );
            node.SetNodePrefab(nodePrefab);
        }
    }

    Vector2 CalcAvePosNodes( Node node1, Node node2)
    {
        Vector2 posNode1 = node1.GetScreenPos();
        Vector2 posNode2 = node2.GetScreenPos();

        return (posNode1 + posNode2) / 2.0f;
    }


    public void UpdateNodePosition( Vector3 inTransPos, int inNodeIndex )
    {
        Node node = nodes[inNodeIndex];
        Vector2 pos = new Vector2(inTransPos.x, inTransPos.y);
        node.SetPos(pos);
    }

    public void IterateEdge(AddEdge myMethodName)
    {
        for (int row = 0; row < numOfDimension; row++)
        {
            for (int column = 0; column < numOfDimension; column++)
            {
                if (row > column)
                {
                    continue;
                }

                //                if (edges[row, column].isActive())
                if (edges[row, column] != null)
                {
                    Edge edge = edges[row, column];
                    int rightNodeIndex = edge.GetRightNodeIndex();
                    int leftNodeIndex = edge.GetLeftNodeIndex();

                    Vector2 posAvg = CalcAvePosNodes(nodes[rightNodeIndex], nodes[leftNodeIndex]);

                    GameObject edgePrefab = myMethodName(posAvg.x, posAvg.y, rightNodeIndex, leftNodeIndex, nodes);
                    edge.SetEdgePrefab(edgePrefab);
                }
            }

        }


    }

    public void IterateEdge(List<Edge> inAddedEdges, AddEdge myMethodName)
    {
        foreach( Edge edge in inAddedEdges ){

            int rightNodeIndex = edge.GetRightNodeIndex();
            int leftNodeIndex = edge.GetLeftNodeIndex();

            Vector2 posAvg = CalcAvePosNodes(nodes[rightNodeIndex], nodes[leftNodeIndex]);

            GameObject edgePrefab = myMethodName(posAvg.x, posAvg.y, rightNodeIndex, leftNodeIndex, nodes);
            edge.SetEdgePrefab(edgePrefab);
        }

    }

    public void IterateEdge( int inNodeIndex )
    {

        for (int row = 0; row < numOfDimension; row++)
        {

            for (int column = 0; column < numOfDimension; column++)
            {
                if (row >= column)
                {
                    continue;
                }

                if (nodes[inNodeIndex].getNodeIndex() != column && nodes[inNodeIndex].getNodeIndex() != row )
                {
                    continue;
                }

                //if (edges[row, column].isActive())
                if (edges[row, column] != null )
                {
                    Edge edge = edges[row, column];
                    int rightNodeIndex = edge.GetRightNodeIndex();
                    int leftNodeIndex = edge.GetLeftNodeIndex();

                    Vector2 posAvg;
                    if ( rightNodeIndex == nodes[inNodeIndex].getNodeIndex())
                    {
                        posAvg = CalcAvePosNodes(nodes[inNodeIndex], nodes[leftNodeIndex]);
                    }
                    else
                    {
                        posAvg = CalcAvePosNodes(nodes[rightNodeIndex], nodes[inNodeIndex]);
                    }
                    edge.UpdatePos(posAvg.x, posAvg.y, rightNodeIndex, leftNodeIndex, nodes);
                }
            }

        }


    }

    public void IterateEdgeForUpdatePrefab(UpdateEdge myMethodName)
    {
        for (int row = 0; row < numOfDimension; row++)
        {
            for (int column = 0; column < numOfDimension; column++)
            {
                if (row >= column)
                {
                    continue;
                }

//                if (edges[row, column].isActive())
                if (edges[row, column] != null )
                {
                    Edge edge = edges[row, column];
                    int rightNodeIndex = edge.GetRightNodeIndex();
                    int leftNodeIndex = edge.GetLeftNodeIndex();

                    Vector2 posAvg = CalcAvePosNodes(nodes[rightNodeIndex], nodes[leftNodeIndex]);

                    GameObject edgePrefab = edge.GetEdgePrefab();

                    myMethodName(posAvg.x, posAvg.y, rightNodeIndex, leftNodeIndex, nodes, edgePrefab);
                }
            }

        }
    }

    public void IterateNodeForUpdatePrefab(UpdateNode myMethodName)
    {
        int nodeIndex;

        foreach (Node node in nodes)
        {
            nodeIndex = node.getNodeIndex();

            GameObject gameObject = node.GetNodePrefab();

            myMethodName( nodeIndex, gameObject );
        }
    }

    void setupEdges( int inNumOfNodes)
    {
        for (int row = 0; row < inNumOfNodes; row++)
        {
            for (int column = 0; column < inNumOfNodes; column++)
            {
                if (row >= column)
                {
                    continue;
                }

                if( link.isLinkPresent( row, column))
                {
//                    edges[row, column].activate();
                }
                else
                {
//                    edges[row, column].deactivate();
                    edges[row, column] = null;
                }

            }

        }
    }

    void initializeEdges( int inNumOfNodes)
    {
        edges = new Edge[inNumOfNodes, inNumOfNodes];

        for ( int row = 0; row < inNumOfNodes; row++)
        {
            for (int column = 0; column < inNumOfNodes; column++)
            {
                if( row >= column)
                {
                    continue;
                }

                edges[row, column] = new Edge( row, column );
            }

        }

        numOfDimension = inNumOfNodes;

    }

    void RemoveNodesWithoutEdges()
    {

    }
/*
    void generateRandom()
    {
        numOfNodes = (int)Random.Range(2.0f, 9.0f);
        nodes = new List<Node>();

        for( int i = 0; i < numOfNodes; i++)
        {
            nodes[i] = new Node(i, new Vector2(Random.Range(-3.0f, +3.0f ), Random.Range(-5.0f, +5.0f) ) );
        }

        int numOfEdges = (int)Random.Range( 1.0f, (numOfNodes * (numOfNodes - 1)) / 2 );

        link = new Link(numOfNodes, numOfEdges);

        initializeEdges(numOfNodes);
        setupEdges(numOfNodes);

    }
*/
/*
    void generateOne()
    {
        numOfNodes = 2;
        nodes = new List<Node>();

        nodes.Add(new Node(0, new Vector2(-1.0f, 0.0f)));
        nodes.Add(new Node(1, new Vector2(+1.0f, 0.0f)));

        link = new Link(type_loop.one);

        initializeEdges(2);
        setupEdges(2);
    }

    void generateTwo()
    {
        numOfNodes = 3;
        nodes = new List<Node>();

        nodes.Add( new Node(0, new Vector2(-1.0f, 0.0f ) ) );
        nodes.Add(new Node(1, new Vector2(+1.0f, 0.0f)));
        nodes.Add(new Node(2, new Vector2(0.0f, +1.0f)));

        link = new Link(type_loop.two);

        initializeEdges(3);
        setupEdges(3);

    }

    void generateThree()
    {
        numOfNodes = 3;
        nodes = new List<Node>();

        nodes.Add(new Node(0, new Vector2(-1.0f, 0.0f)));
        nodes.Add(new Node(1, new Vector2(+1.0f, 0.0f)));
        nodes.Add(new Node(2, new Vector2(0.0f, +1.0f)));

        link = new Link(type_loop.three);

        initializeEdges(3);
        setupEdges(3);

    }

    void generateFour()
    {
        numOfNodes = 4;
        nodes = new List<Node>();

        nodes.Add(new Node(0, new Vector2(-1.0f, -1.0f)));
        nodes.Add(new Node(1, new Vector2(+1.0f, -1.0f)));
        nodes.Add(new Node(2, new Vector2(+1.0f, +1.0f)));
        nodes.Add(new Node(3, new Vector2(-1.0f, +1.0f)));

        link = new Link(type_loop.four);

        initializeEdges(4);
        setupEdges(4);

    }

    void generateFive()
    {
        numOfNodes = 4;
        nodes = new List<Node>();

        nodes.Add(new Node(0, new Vector2(-1.0f, -1.0f)));
        nodes.Add(new Node(1, new Vector2(+1.0f, -1.0f)));
        nodes.Add(new Node(2, new Vector2(+1.0f, +1.0f)));
        nodes.Add(new Node(3, new Vector2(-1.0f, +1.0f)));

        link = new Link(type_loop.five);

        initializeEdges(4);
        setupEdges(4);

    }

    void generateSix()
    {
        numOfNodes = 4;
        nodes = new List<Node>();

        nodes.Add(new Node(0, new Vector2(-1.0f, -1.0f)));
        nodes.Add(new Node(1, new Vector2(+1.0f, -1.0f)));
        nodes.Add(new Node(2, new Vector2(+1.0f, +1.0f)));
        nodes.Add(new Node(3, new Vector2(-1.0f, +1.0f)));

        link = new Link(type_loop.six);

        initializeEdges(4);
        setupEdges(4);

    }
*/
    void setupLink(Edge[,] inEdges, int inNumOfIndex, Link inLink )
    {

        for (int row = 0; row < inNumOfIndex; row++)
        {
            for (int column = 0; column < inNumOfIndex; column++)
            {
                if (row >= column)
                {
                    continue;
                }

//                if(inEdges[row,column].isActive() == true)
                if (inEdges[row, column] != null )
                {
                        inLink.makeLink(row, column);
                }
                else
                {
                    inLink.clearLink(row, column);
                }
            }
        }
    }

    public int combineNodes( int in1stNodeIndex, int in2ndNodeIndex, Vector2 inNewPos, List<Edge> outEdgesMerge )
    {

        // debug
//        if( in1stNodeIndex == in2ndNodeIndex)
 //       {
  //          Application.Quit();
   //     }

        List<Node> newNodes;
        int newNumOfNodes;

        newNumOfNodes = numOfNodes - 1;
        newNodes = new List<Node>();

        Edge[,] newEdges;

        Link newLink;

        //
        // Create new nodes.
        //

        int tmpNewNumOfNodes = 0;
        for( int i = 0; i < numOfNodes; i++)
        {
            if ( i == in1stNodeIndex || i == in2ndNodeIndex)
            {
                continue;
            }
            else
            {
                float x = nodes[i].GetXPos();
                float y = nodes[i].GetYPos();
                Vector2 pos = new Vector2(x, y);

                GameObject nodePrefab = nodes[i].GetNodePrefab();
                int nodeValue = nodes[i].getNodeValue();

//              newNodes[tmpNewNumOfNodes] = new Node(tmpNewNumOfNodes, pos );
                newNodes.Add( new Node(tmpNewNumOfNodes, nodeValue, pos ));
                newNodes[tmpNewNumOfNodes].SetNodePrefab(nodePrefab);

                // update node index in the game object.
                NodeComponent nodeComponent = nodePrefab.GetComponent<NodeComponent>();
                nodeComponent.SetNodeIndex(tmpNewNumOfNodes);

            }

            tmpNewNumOfNodes++;
        }

        // a node prefab corresponding to this instance will be created later in enclosing caller function.
        int nodeValue1st = nodes[in1stNodeIndex].getNodeValue();
        int nodeValue2nd = nodes[in2ndNodeIndex].getNodeValue();
        int newNodeValue = nodeValue1st + nodeValue2nd;
        if( newNodeValue > 9)
        {
            newNodeValue -= 9;
        }

        newNodes.Add(new Node(tmpNewNumOfNodes, newNodeValue, inNewPos));

        // debug
//        if( checkNodePrefabConsistency(newNodes ) == false)
 //       {
  //          Application.Quit();
   //     }

        //
        // Rearrange edges.
        //

        newEdges = new Edge[newNumOfNodes, newNumOfNodes];

        int newRow = 0;
        for (int row = 0; row < numOfNodes; row++)
        {

            if ( row == in1stNodeIndex || row == in2ndNodeIndex )
            {
                continue;
            }

            int newColumn = newRow+1;
            for (int column = 0; column < numOfNodes; column++)
            {
                if (row >= column)
                {
                    continue;
                }

                if( column == in1stNodeIndex || column == in2ndNodeIndex )
                {
                    continue;
                }

                newEdges[newRow, newColumn] = edges[row, column];

                if (newEdges[newRow, newColumn] != null)
                {
                    newEdges[newRow, newColumn].SetRightNodeIndex(newColumn);
                    newEdges[newRow, newColumn].SetLeftNodeIndex(newRow);
                }

                newColumn++;

            }

            newRow++;

        }

        // choose an active edge in horizontal direction.
        Edge[] hEdges = new Edge[numOfNodes];
        for (int row = 0; row < numOfNodes; row++)
        {
            for (int column = 0; column < numOfNodes; column++)
            {
                if (row >= column)
                {
                    continue;
                }

                if( row == in1stNodeIndex || row == in2ndNodeIndex)
                {
                    continue;
                }

                if( column == in1stNodeIndex || column == in2ndNodeIndex)
                {
//                  if( edges[row,column].isActive() == true && hEdges[row] != null )
                    if (edges[row, column] != null == true && hEdges[row] != null)
                    {
                            outEdgesMerge.Add(edges[row, column]);
                    }
//                  else if (edges[row, column].isActive() == true )
                    else if (edges[row, column] != null )
                    {
                        hEdges[row] = edges[row, column];
                    }
                }
            }
        }

        int newNumOfRow = 0;
        for( int row = 0; row < numOfNodes; row++)
        {
            if (row == in1stNodeIndex || row == in2ndNodeIndex)
            {
                continue;
            }

            if( hEdges[row] != null)
            {
                newEdges[newNumOfRow, newNumOfNodes - 1] = hEdges[row];
                newEdges[newNumOfRow, newNumOfNodes - 1].SetRightNodeIndex(newNumOfNodes - 1);
                newEdges[newNumOfRow, newNumOfNodes - 1].SetLeftNodeIndex(newNumOfRow);
            }

            newNumOfRow++;
        }

        // choose an active edge in vertical direction.
        Edge[] vEdges = new Edge[numOfNodes];
        for (int row = 0; row < numOfNodes; row++)
        {
            for (int column = 0; column < numOfNodes; column++)
            {
                if (row >= column)
                {
                    continue;
                }

                if (column == in1stNodeIndex || column == in2ndNodeIndex)
                {
                    continue;
                }

                if (row == in1stNodeIndex || row == in2ndNodeIndex)
                {
//                  if (edges[row, column].isActive() == true && vEdges[column] != null )
                    if (edges[row, column] != null == true && vEdges[column] != null)
                    {
                            outEdgesMerge.Add(edges[row, column]);
                    }
//                  else if (edges[row, column].isActive() == true)
                    else if (edges[row, column] != null )
                    {
                        vEdges[column] = edges[row, column];
                    }
                }
            }
        }

        newNumOfRow = 0;
        for (int column = 0; column < numOfNodes; column++)
        {
            if (column == in1stNodeIndex || column == in2ndNodeIndex)
            {
                continue;
            }

            if(vEdges[column] != null)
            {
                if (newEdges[newNumOfRow, newNumOfNodes - 1] != null)
                {
                    outEdgesMerge.Add(vEdges[column]);
                }
                else
                {
                    newEdges[newNumOfRow, newNumOfNodes - 1] = vEdges[column];
                    newEdges[newNumOfRow, newNumOfNodes - 1].SetRightNodeIndex(newNumOfNodes - 1);
                    newEdges[newNumOfRow, newNumOfNodes - 1].SetLeftNodeIndex(newNumOfRow);
                }
            }

            newNumOfRow++;
        }

        //
        // create a link.
        //

        newLink = new Link(newNumOfNodes);
        setupLink(newEdges, newNumOfNodes, newLink);

        // debug
//        if (newNodes.Count != newNumOfNodes )
 //       {
  //          Application.Quit();
   //     }

        //
        // Replacing existing data structures.
        //

        nodes = newNodes;
        numOfNodes = newNumOfNodes;

        edges = newEdges;
        numOfDimension = newNumOfNodes;

        return tmpNewNumOfNodes;
    }

    public Edge GetEdge( int in1stIndex, int in2ndIndex)
    {
        try
        {
            if (in1stIndex >= in2ndIndex)
            {
                Edge edge = edges[in2ndIndex, in1stIndex];
                return edge;
            }
            else
            {
                Edge edge = edges[in1stIndex, in2ndIndex];
                return edge;
            }
        }
        catch (System.IndexOutOfRangeException exp)
        {
            Debug.Log(exp.ToString());
            Application.Quit();
            return null;
        }

    }

    public Node GetNode( int inNodeIndex)
    {
        return nodes[inNodeIndex];
    }

    public void Spawn1Node0Edge(List<Node> outAddedNode, List<Edge> outAddedEdge, SpawnInfo inSpawnInfo)
    {
        //
        // Spawn 1 node and 0 edge.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex, 1, new Vector2(0.0f, 0.0f), inSpawnInfo);
        nodes.Add(newNode1);
        numOfNodes += 1;

        AddEdgesSpawn1Node0Edge(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
    }

    public void Spawn2Node1Edge(List<Node> outAddedNode, List<Edge> outAddedEdge, SpawnInfo inSpawnInfo)
    {
        //
        // Spawn 2 node and 1 edge.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex    , 1, new Vector2(-1.0f, 0.0f), inSpawnInfo );
        Node newNode2 = new Node(newNodeIndex + 1, 2, new Vector2(+1.0f, 0.0f), inSpawnInfo );
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        numOfNodes += 2;

        AddEdgesSpawn2Node1Edge(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
    }


    public void Spawn3Node3Edge(List<Node> outAddedNode, List<Edge> outAddedEdge, SpawnInfo inSpawnInfo)
    {
        //
        // Spawn 3 nodes and 3 edges.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex,     1, new Vector2(-0.5f,  0.0f), inSpawnInfo);
        Node newNode2 = new Node(newNodeIndex + 1, 2, new Vector2( 0.0f, +1.0f), inSpawnInfo);
        Node newNode3 = new Node(newNodeIndex + 2, 3, new Vector2(+0.5f,  0.0f), inSpawnInfo);
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        nodes.Add(newNode3);
        numOfNodes += 3;

        AddEdgesSpawn3Node3Edge(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
        outAddedNode.Add(newNode3);
    }

    
    public void Spawn3Node2Edge(List<Node> outAddedNode, List<Edge> outAddedEdge, SpawnInfo inSpawnInfo)
    {
        //
        // Spawn 3 nodes and 2 edges.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex,     1, new Vector2(-0.5f,  0.0f), inSpawnInfo);
        Node newNode2 = new Node(newNodeIndex + 1, 2, new Vector2( 0.0f, +1.0f), inSpawnInfo);
        Node newNode3 = new Node(newNodeIndex + 2, 3, new Vector2(+0.5f,  0.0f), inSpawnInfo);
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        nodes.Add(newNode3);
        numOfNodes += 3;

        AddEdgesSpawn3Node2Edge(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
        outAddedNode.Add(newNode3);
    }

    public void Spawn4Node4Edge(List<Node> outAddedNode, List<Edge> outAddedEdge, SpawnInfo inSpawnInfo)
    {
        //
        // Spawn 4 nodes and 4 edges.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex,     1, new Vector2(-0.5f, -0.5f), inSpawnInfo);
        Node newNode2 = new Node(newNodeIndex + 1, 2, new Vector2(+0.5f, -0.5f), inSpawnInfo);
        Node newNode3 = new Node(newNodeIndex + 2, 3, new Vector2(+0.5f, +0.5f), inSpawnInfo);
        Node newNode4 = new Node(newNodeIndex + 3, 4, new Vector2(-0.5f, +0.5f), inSpawnInfo);
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        nodes.Add(newNode3);
        nodes.Add(newNode4);
        numOfNodes += 4;

        AddEdgesSpawn4Node4Edge(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
        outAddedNode.Add(newNode3);
        outAddedNode.Add(newNode4);
    }

    public void Spawn4Node3Edge(List<Node> outAddedNode, List<Edge> outAddedEdge, SpawnInfo inSpawnInfo)
    {
        //
        // Spawn 4 nodes and 3 edges.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex    , 1, new Vector2(-0.5f, -0.5f), inSpawnInfo);
        Node newNode2 = new Node(newNodeIndex + 1, 2, new Vector2(+0.5f, -0.5f), inSpawnInfo);
        Node newNode3 = new Node(newNodeIndex + 2, 3, new Vector2(+0.5f, +0.5f), inSpawnInfo);
        Node newNode4 = new Node(newNodeIndex + 3, 4, new Vector2(-0.5f, +0.5f), inSpawnInfo);
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        nodes.Add(newNode3);
        nodes.Add(newNode4);
        numOfNodes += 4;

        AddEdgesSpawn4Node3Edge(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
        outAddedNode.Add(newNode3);
        outAddedNode.Add(newNode4);
    }

    public void Spawn4Node5Edge(List<Node> outAddedNode, List<Edge> outAddedEdge, SpawnInfo inSpawnInfo)
    {
        //
        // Spawn 4 nodes and 5 edges.
        //

        int newNodeIndex = nodes.Count;
        Node newNode1 = new Node(newNodeIndex,     1, new Vector2(-0.5f, -0.5f), inSpawnInfo);
        Node newNode2 = new Node(newNodeIndex + 1, 2, new Vector2(+0.5f, -0.5f), inSpawnInfo);
        Node newNode3 = new Node(newNodeIndex + 2, 3, new Vector2(+0.5f, +0.5f), inSpawnInfo);
        Node newNode4 = new Node(newNodeIndex + 3, 4, new Vector2(-0.5f, +0.5f), inSpawnInfo);
        nodes.Add(newNode1);
        nodes.Add(newNode2);
        nodes.Add(newNode3);
        nodes.Add(newNode4);
        numOfNodes += 4;

        AddEdgesSpawn4Node5Edge(outAddedEdge);

        //        link = new Link(type_loop.five);

        //      setupEdges(4);


        outAddedNode.Add(newNode1);
        outAddedNode.Add(newNode2);
        outAddedNode.Add(newNode3);
        outAddedNode.Add(newNode4);
    }

    public void InvalidateNodeComponentPosition( int inNodeIndex)
    {
        if( nodes.Count <= inNodeIndex)
        {
            Application.Quit();
        }

        nodes[inNodeIndex].InvalidateNodeComponentPosition();
    }


    //
    // Entire methods after this line are not necessary for executing program, but just for debugging purpose.
    //


    bool checkNodePrefabConsistency(List<Node> inNodes)
    {
        for (int i = 0; i < inNodes.Count; i++)
        {
            int nodeIndex = inNodes[i].getNodeIndex();
            GameObject prefab = inNodes[i].GetNodePrefab();
            if (prefab != null)
            {
                NodeComponent nodeComponent = prefab.GetComponent<NodeComponent>();
                int prefabNodeIndex = nodeComponent.GetNodeIndex();

                if (nodeIndex != prefabNodeIndex)
                {
                    Application.Quit();
                    return false;
                }
            }

            for (int j = i + 1; j < inNodes.Count; j++)
            {
                int nodeIndex2 = inNodes[j].getNodeIndex();
                if (nodeIndex == nodeIndex2)
                {
                    Application.Quit();
                    return false;
                }
            }
        }

        return true;
    }


}

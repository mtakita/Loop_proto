﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopComponent : MonoBehaviour
{
    // this must be initialized after instantiated.
//    public type_loop typeLoop;
    public GameObject nodePrefabNumber0;
    public GameObject nodePrefabNumber1;
    public GameObject nodePrefabNumber2;
    public GameObject nodePrefabNumber3;
    public GameObject nodePrefabNumber4;
    public GameObject nodePrefabNumber5;
    public GameObject nodePrefabNumber6;
    public GameObject nodePrefabNumber7;
    public GameObject nodePrefabNumber8;
    public GameObject nodePrefabNumber9;
    public GameObject nodePrefabNumberEmpty;

    public GameObject edgePrefab;

    // local variables.

    Loop loop;
    List<GameObject> nodes;
    List<GameObject> edges;

    public Loop GetLoop()
    {
        return loop;
    }

    // Use this for initialization
    void Start()
    {
        nodes = new List<GameObject>();
        edges = new List<GameObject>();

        loop = new Loop();

//        loop = new Loop(typeLoop);
//        loop.IterateNode(AddNode);
//        loop.IterateEdge(AddEdge);

    }
/*
    public void AddEdgseNodesOne()
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.AddEdgesNodesOne(addedNode, addedEdge);
        loop.IterateNode(addedNode, AddNode);

        // no process for edges since there is added edge.

    }

    public void AddEdgseNodesTwo()
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.AddEdgesNodesTwo(addedNode, addedEdge);

        loop.IterateNode(addedNode, AddNode);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void AddEdgseNodesThree()
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.AddEdgesNodesThree(addedNode, addedEdge);

        loop.IterateNode(addedNode, AddNode);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void AddEdgseNodesFour()
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.AddEdgesNodesFour(addedNode, addedEdge);

        loop.IterateNode(addedNode, AddNode);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void AddEdgseNodesFive()
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.AddEdgesNodesFive(addedNode, addedEdge);

        loop.IterateNode(addedNode, AddNode);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void AddEdgseNodesSix()
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.AddEdgesNodesSix(addedNode, addedEdge);

        loop.IterateNode(addedNode, AddNode);
        loop.IterateEdge(addedEdge, AddEdge);
    }
*/
    public GameObject AddEdge(float x, float y, int rightNodeIndex, int leftNodeIndex, List<Node> inNodes )
    {
        GameObject edge;
        Transform tr;
        LineRenderer lr;

        edge = Instantiate(edgePrefab, new Vector3(x, y, 0.0f), Quaternion.identity);

        edges.Add(edge);
        tr = edge.GetComponent<Transform>();
        tr.position = new Vector3(x, y, 0.0f);
//        tr.transform.parent = this.transform;

        lr = edge.GetComponent<LineRenderer>();
        lr.startWidth = 0.05f;
        lr.endWidth = 0.05f;

        Vector3 rightPos = new Vector3(inNodes[rightNodeIndex].GetXPos(), inNodes[rightNodeIndex].GetYPos(), 0);
        lr.SetPosition(0, rightPos);

        Vector3 leftPos = new Vector3(inNodes[leftNodeIndex].GetXPos(), inNodes[leftNodeIndex].GetYPos(), 0);
        lr.SetPosition(1, leftPos);

        return edge;

    }

    public GameObject AddNode( float x, float y, int number, int inNodeIndex )
    {
        GameObject node;
        Transform tr;
        NodeComponent nodeComp;

        switch ( number)
        {

            case 1:
                node = Instantiate(nodePrefabNumber1, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex( inNodeIndex );
                nodeComp.SetLoop(loop);

                return node;

            case 2:
                node = Instantiate(nodePrefabNumber2, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                return node;

            case 3:
                node = Instantiate(nodePrefabNumber3, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                return node;

            case 4:
                node = Instantiate(nodePrefabNumber4, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                return node;

            case 5:
                node = Instantiate(nodePrefabNumber5, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                return node;

            case 6:
                node = Instantiate(nodePrefabNumber6, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                return node;

            case 7:
                node = Instantiate(nodePrefabNumber7, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                return node;

            case 8:
                node = Instantiate(nodePrefabNumber8, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                return node;

            case 9:
                node = Instantiate(nodePrefabNumber9, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                return node;

        }

        return null;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
    }

    void OnMouseDrag()
    {
    }

    public GameObject CreateNode(Vector2 inPos, int inNodeIndex, type_node_value inNodeValue )
    {
        /*
        GameObject[] nodePrefabs = new GameObject[] {
            nodePrefabNumber0,
            nodePrefabNumber1,
            nodePrefabNumber2,
            nodePrefabNumber3,
            nodePrefabNumber4,
            nodePrefabNumber5,
            nodePrefabNumber6,
            nodePrefabNumber7,
            nodePrefabNumber8,
            nodePrefabNumber9,
            nodePrefabNumberEmpty
        };
*/
        GameObject node;
        Transform tr;
        NodeComponent nodeComponent;

        GameObject selectPreFab = null;
        switch( inNodeValue)
        {
            case type_node_value.type_node_value_0:
                selectPreFab = nodePrefabNumber0;
                break;
            case type_node_value.type_node_value_1:
                selectPreFab = nodePrefabNumber1;
                break;
            case type_node_value.type_node_value_2:
                selectPreFab = nodePrefabNumber2;
                break;
            case type_node_value.type_node_value_3:
                selectPreFab = nodePrefabNumber3;
                break;
            case type_node_value.type_node_value_4:
                selectPreFab = nodePrefabNumber4;
                break;
            case type_node_value.type_node_value_5:
                selectPreFab = nodePrefabNumber5;
                break;
            case type_node_value.type_node_value_6:
                selectPreFab = nodePrefabNumber6;
                break;
            case type_node_value.type_node_value_7:
                selectPreFab = nodePrefabNumber7;
                break;
            case type_node_value.type_node_value_8:
                selectPreFab = nodePrefabNumber8;
                break;
            case type_node_value.type_node_value_9:
                selectPreFab = nodePrefabNumber9;
                break;
            case type_node_value.type_node_value_empty:
                selectPreFab = nodePrefabNumberEmpty;
                break;
        }

        node = Instantiate(selectPreFab, new Vector3(inPos.x, inPos.y, 0.0f), Quaternion.identity);
    
        nodes.Add(node);
        tr = node.GetComponent<Transform>();
        tr.position = new Vector3(inPos.x, inPos.y, 0.0f);

        nodeComponent = node.GetComponent<NodeComponent>();
        nodeComponent.SetNodeIndex(inNodeIndex);
        nodeComponent.SetLoop(loop);

        return node;
    }

    public void Spawn1Node0Edge(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn1Node0Edge(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn2Node1Edge(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn2Node1Edge(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo );
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn3Node3Edge(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn3Node3Edge(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn3Node2Edge(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn3Node2Edge(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn4Node4Edge(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn4Node4Edge(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn4Node3Edge(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn4Node3Edge(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn4Node5Edge(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn4Node5Edge(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn4Node6Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn4Node6Edge2Occupy(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn4Node4Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn4Node4Edge2Occupy(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn4Node3Edge3Occupy(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn4Node3Edge3Occupy(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn4Node3Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn4Node3Edge2Occupy(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn4Node3Edge2Occupy1(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn4Node3Edge2Occupy1(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn4Node3Edge2Occupy2(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn4Node3Edge2Occupy2(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn3Node2Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn3Node2Edge2Occupy(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn3Node2Edge1Occupy(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn3Node2Edge1Occupy(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn3Node3Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn3Node3Edge2Occupy(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn3Node3Edge1Occupy(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn3Node3Edge1Occupy(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }

    public void Spawn2Node1Edge1Occupy(SpawnInfo inSpawnInfo)
    {
        List<Node> addedNode = new List<Node>();
        List<Edge> addedEdge = new List<Edge>();
        loop.Spawn2Node1Edge1Occupy(addedNode, addedEdge, inSpawnInfo);

        loop.IterateNodeSpawn(addedNode, SpawnNode, inSpawnInfo);
        loop.IterateEdge(addedEdge, AddEdge);
    }


    public GameObject SpawnNode(float x, float y, type_node_value number, int inNodeIndex, SpawnInfo inSpawnInfo )
    {
        GameObject node;
        Transform tr;
        NodeComponent nodeComp;

        switch (number)
        {

            case type_node_value.type_node_value_1:
                node = Instantiate(nodePrefabNumber1, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;

            case type_node_value.type_node_value_2:
                node = Instantiate(nodePrefabNumber2, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;

            case type_node_value.type_node_value_3:
                node = Instantiate(nodePrefabNumber3, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;

            case type_node_value.type_node_value_4:
                node = Instantiate(nodePrefabNumber4, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;

            case type_node_value.type_node_value_5:
                node = Instantiate(nodePrefabNumber5, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;

            case type_node_value.type_node_value_6:
                node = Instantiate(nodePrefabNumber6, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;

            case type_node_value.type_node_value_7:
                node = Instantiate(nodePrefabNumber7, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;

            case type_node_value.type_node_value_8:
                node = Instantiate(nodePrefabNumber8, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;

            case type_node_value.type_node_value_9:
                node = Instantiate(nodePrefabNumber9, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;

            case type_node_value.type_node_value_empty:
                node = Instantiate(nodePrefabNumberEmpty, new Vector3(x, y, 0.0f), Quaternion.identity);

                nodes.Add(node);
                tr = node.GetComponent<Transform>();
                tr.position = new Vector3(x, y, 0.0f);
                //                tr.transform.parent = this.transform;

                nodeComp = node.GetComponent<NodeComponent>();
                nodeComp.SetNodeIndex(inNodeIndex);
                nodeComp.SetLoop(loop);

                inSpawnInfo.AddNodeIndex(inNodeIndex);

                return node;
        }

        return null;
    }



}

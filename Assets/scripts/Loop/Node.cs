﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    int nodeIndex;
    type_node_value nodeValue;

    Vector2 localPos;
    GameObject nodePrefab;

    SpawnInfo spawnInfo;

    //
    // work variables for path finding.
    //
    int parentNodeIndex;
    float cost;
    
    public enum enum_status
    {
        none,
        idle,
        pre_spawn
    };

    enum_status status;


    public Node(int inNewNodeIndex, type_node_value inNodeValue, Vector2 initLocalPos, SpawnInfo inSpawnInfo )
    {
        nodeIndex = inNewNodeIndex;
        nodeValue = inNodeValue;
        localPos = initLocalPos;

        spawnInfo = inSpawnInfo;

        status = enum_status.pre_spawn;
    }

    public Node( int newNodeIndex, type_node_value inNodeValue, Vector2 initLocalPos )
    {
        nodeIndex = newNodeIndex;
        nodeValue = inNodeValue;
        localPos = initLocalPos;

        status = enum_status.idle;
    }

    public void InvalidateNodeComponentPosition()
    {
        NodeComponent nodeComponent = nodePrefab.GetComponent<NodeComponent>();
        nodeComponent.InvalidateNodeComponentPosition();
    }

    public Vector2 GetScreenPos()
    {
        if (status == enum_status.idle)
        {
            return localPos;
        }
        else
        {
            return localPos + spawnInfo.GetCurrentPosition();
        }
    }

    public void SetScreenPos( Vector2 inPosition)
    {
        if (status == enum_status.idle)
        {
            localPos = inPosition;
        }
        else
        {
            localPos = inPosition - spawnInfo.GetCurrentPosition();
        }
    }

    public enum_status GetStatus()
    {
        return status;
    }

    public void InitializePosition()
    {
        localPos = localPos + spawnInfo.GetCurrentPosition();
    }

    public void SetStatus(enum_status inStatus)
    {
        status = inStatus;
    }

    public void SetNodePrefab(GameObject inNodePrefab)
    {
        nodePrefab = inNodePrefab;
    }

    public GameObject GetNodePrefab()
    {
        return nodePrefab;
    }

    public void SetPos(Vector2 inPos )
    {
        localPos = inPos;
    }


    public int getNodeIndex()
    {
        return nodeIndex;
    }

    public float GetXPos()
    {
        if (status == enum_status.idle)
        {
            return localPos.x;
        }
        else
        {
            return localPos.x + spawnInfo.GetCurrentPosition().x;

        }
    }

    public float GetYPos()
    {
        if (status == enum_status.idle)
        {
            return localPos.y;
        }
        else
        {
            return localPos.y + spawnInfo.GetCurrentPosition().y;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public type_node_value getNodeValue()
    {
        return nodeValue;
    }

    public int GetParentNodeIndex()
    {
        return parentNodeIndex;
    }

    public void SetParentNodeIndex( int inParentNodeIndex)
    {
        parentNodeIndex = inParentNodeIndex;
    }

    public float GetCost()
    {
        return cost;
    }

    public void SetCost(float inCost )
    {
        cost = inCost;
    }
}

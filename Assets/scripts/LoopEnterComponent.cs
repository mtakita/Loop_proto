using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopEnterComponent : MonoBehaviour
{
    SpawnInfo spawnInfo;
    Loop loop;

    public void SetSpawnInfo( SpawnInfo inSpawnInfo)
    {
        spawnInfo = inSpawnInfo;
    }

    public void SetLoop(Loop inLoop )
    {
        loop = inLoop;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    void DestroyLoopEnter()
    {
        foreach( int nodeIndex in spawnInfo.GetNodeIndecies() )
        {
            loop.GetNode(nodeIndex).SetStatus(Node.enum_status.idle);
            loop.GetNode(nodeIndex).InitializePosition();
        }

        Destroy(gameObject);
    }

    void InvalidateNodeComponentPosition()
    {
        foreach(int nodeIndex in spawnInfo.GetNodeIndecies())
        {
            loop.InvalidateNodeComponentPosition(nodeIndex);
        }
    }


    // Update is called once per frame
    void Update()
    {
        //
        // update group nodes position.
        //

        float t = spawnInfo.GetT();
        if ( t > 1.0f)
        {
            DestroyLoopEnter();
            return;
        }

        //        t += (1.0f/30.0f)*Time.deltaTime;
        t += (2.0f)*Time.deltaTime;
        spawnInfo.SetT(t);

        float h = 3 * Mathf.Pow(t, 2) - 2 * Mathf.Pow(t, 3);

        Vector2 pos = spawnInfo.GetPosition() +  h * spawnInfo.GetRPosition();
        spawnInfo.SetCurrentPosition(pos);

        InvalidateNodeComponentPosition();

        //
        // update edge position
        //

        foreach ( int nodeIndex in spawnInfo.GetNodeIndecies())
        {
            loop.IterateEdge(nodeIndex);
        }
    }
}

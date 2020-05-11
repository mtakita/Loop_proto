using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum type_node_edge
{
    random,
    type_1node0edge,
    type_2node1edge,
    type_3node3edge,
    type_3node2edge,
    type_4node3edge,
    type_4node4edge,
    type_4node5edge,
    type_4node6edge2occupy,
    type_4node4edge2occupy,
    type_4node3edge3occupy,
    type_4node3edge2occupy,
    type_4node3edge2occupy1,
    type_4node3edge2occupy2,
    type_3node2edge2occupy,
    type_3node2edge1occupy,
    type_3node3edge2occupy,
    type_3node3edge1occupy,
    type_2node1edge1occupy,
};

public enum type_node_value
{
    type_node_value_0,
    type_node_value_1,
    type_node_value_2,
    type_node_value_3,
    type_node_value_4,
    type_node_value_5,
    type_node_value_6,
    type_node_value_7,
    type_node_value_8,
    type_node_value_9,
    type_node_value_empty,
};

public class GameObjectControl : MonoBehaviour
{
    public GameObject loopPrefab;
    public GameObject loopEnterPrefab;

    GameObject loop;

    //
    // spawn
    //
    float spawnTimer;
/*
    public void RegenerateRandom()
    {
        if( loop == null)
        {
            loop = Instantiate(loopPrefab, new Vector3(0.0f, -3.0f, 0.0f), Quaternion.identity);
        }

        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.typeLoop = type_loop.random;

    }
*/

    public void Spawn1Node0Edge()
    {
        Spawn(type_node_edge.type_1node0edge);
    }

    public void Spawn2Node1Edge()
    {
        Spawn(type_node_edge.type_2node1edge);
    }

    public void Spawn3Node3Edge()
    {
        Spawn(type_node_edge.type_3node3edge);
    }

    public void Spawn3Node2Edge()
    {
        Spawn(type_node_edge.type_3node2edge);
    }

    public void Spawn4Node4Edge()
    {
        Spawn(type_node_edge.type_4node4edge);
    }

    public void Spawn4Node3Edge()
    {
        Spawn(type_node_edge.type_4node3edge);
    }

    public void Spawn4Node5Edge()
    {
        Spawn(type_node_edge.type_4node5edge);
    }

    public void Spawn4Node6Edge2Occupy()
    {
        Spawn(type_node_edge.type_4node6edge2occupy);
    }

    public void Spawn4Node4Edge2Occupy()
    {
        Spawn(type_node_edge.type_4node4edge2occupy);
    }

    public void Spawn4Node3Edge3Occupy()
    {
        Spawn(type_node_edge.type_4node3edge3occupy);
    }

    public void Spawn4Node3Edge2Occupy()
    {
        Spawn(type_node_edge.type_4node3edge2occupy);
    }

    public void Spawn4Node3Edge2Occupy1()
    {
        Spawn(type_node_edge.type_4node3edge2occupy1);
    }

    public void Spawn4Node3Edge2Occupy2()
    {
        Spawn(type_node_edge.type_4node3edge2occupy2);
    }

    public void Spawn3Node2Edge2Occupy()
    {
        Spawn(type_node_edge.type_3node2edge2occupy);
    }

    public void Spawn3Node2Edge1Occupy()
    {
        Spawn(type_node_edge.type_3node2edge1occupy);
    }

    public void Spawn3Node3Edge2Occupy()
    {
        Spawn(type_node_edge.type_3node3edge2occupy);
    }

    public void Spawn3Node3Edge1Occupy()
    {
        Spawn(type_node_edge.type_3node3edge1occupy);
    }

    public void Spawn2Node1Edge1Occupy()
    {
        Spawn(type_node_edge.type_2node1edge1occupy);
    }

    // Start is called before the first frame update
    void Start()
    {
        loop = Instantiate(loopPrefab, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        spawnTimer = 0.0f;
    }

    public void Spawn1Node0Edge(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn1Node0Edge(inSpawnInfo);
    }

    public void Spawn2Node1Edge( SpawnInfo inSpawnInfo )
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn2Node1Edge(inSpawnInfo);
    }

    public void Spawn3Node3Edge(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn3Node3Edge(inSpawnInfo);
    }

    public void Spawn3Node2Edge(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn3Node2Edge(inSpawnInfo);
    }

    public void Spawn4Node4Edge(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn4Node4Edge(inSpawnInfo);
    }

    public void Spawn4Node3Edge(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn4Node3Edge(inSpawnInfo);
    }

    public void Spawn4Node5Edge(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn4Node5Edge(inSpawnInfo);
    }

    public void Spawn4Node6Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn4Node6Edge2Occupy(inSpawnInfo);
    }

    public void Spawn4Node4Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn4Node4Edge2Occupy(inSpawnInfo);
    }

    public void Spawn4Node3Edge3Occupy(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn4Node3Edge3Occupy(inSpawnInfo);
    }

    public void Spawn4Node3Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn4Node3Edge2Occupy(inSpawnInfo);
    }

    public void Spawn4Node3Edge2Occupy1(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn4Node3Edge2Occupy1(inSpawnInfo);
    }

    public void Spawn4Node3Edge2Occupy2(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn4Node3Edge2Occupy2(inSpawnInfo);
    }

    public void Spawn3Node2Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn3Node2Edge2Occupy(inSpawnInfo);
    }

    public void Spawn3Node2Edge1Occupy(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn3Node2Edge1Occupy(inSpawnInfo);
    }

    public void Spawn3Node3Edge2Occupy(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn3Node3Edge2Occupy(inSpawnInfo);
    }

    public void Spawn3Node3Edge1Occupy(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn3Node3Edge1Occupy(inSpawnInfo);
    }

    public void Spawn2Node1Edge1Occupy(SpawnInfo inSpawnInfo)
    {
        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.Spawn2Node1Edge1Occupy(inSpawnInfo);
    }

    void Spawn(type_node_edge inType )
    {
        //
        // locate the initial position outside the screen at random..
        //

        int sideOfOffStage = (int)(Random.Range(0.0f, 3.0f));

        Vector2 p = new Vector2();

        switch( sideOfOffStage)
        {
            case 0:
                p = new Vector2(-6.0f, 0.0f);
                break;
            case 1:
                p = new Vector2( 0.0f, +8.0f);
                break;
            case 2:
                p = new Vector2(+6.0f, 0.0f);
                break;
            case 3:
                p = new Vector2(0.0f, +8.0f);
                break;
        }

        float r = Random.Range(0.0f, 3.0f);
        float theta = Random.Range(0.0f, 2 * Mathf.PI);

        Vector2 posOffset = new Vector2(r * Mathf.Cos(theta), r * Mathf.Sin(theta));

        Vector2 pos = p + posOffset;


        //
        // locate destination position in the screen.
        //

        int sideOfScreen = (int)(Random.Range(0.0f, 3.0f));

        Vector2 d = new Vector2();

        switch (sideOfScreen)
        {
            case 0:
                d = new Vector2(-2.0f, 0.0f);
                break;
            case 1:
                d = new Vector2(0.0f, +4.0f);
                break;
            case 2:
                d = new Vector2(+2.0f, 0.0f);
                break;
            case 3:
                d = new Vector2(0.0f, +4.0f);
                break;
        }

        d = new Vector2(0.0f, 0.0f);

        float dr = Random.Range(0.0f, 2.0f);
        float dTheta = Random.Range(0.0f, 2 * Mathf.PI);

        Vector2 dPosOffset = new Vector2(dr * Mathf.Cos(dTheta), r * Mathf.Sin(dTheta));

        Vector2 dPos = d + dPosOffset;

        Vector2 rPos = dPos - pos;

        SpawnInfo spawnInfo = new SpawnInfo();
        spawnInfo.SetPosition(pos);
        spawnInfo.SetRPosition(rPos);
        spawnInfo.SetCurrentPosition(pos);

        //
        // spawn nodes.
        //

        if (inType == type_node_edge.random)
        {
            int typeToGenerate = Random.Range(0, 7);
            switch (typeToGenerate)
            {
                case 0:
                    Spawn1Node0Edge(spawnInfo);
                    break;
                case 1:
                    Spawn2Node1Edge(spawnInfo);
                    break;
                case 2:
                    Spawn3Node3Edge(spawnInfo);
                    break;
                case 3:
                    Spawn3Node2Edge(spawnInfo);
                    break;
                case 4:
                    Spawn4Node4Edge(spawnInfo);
                    break;
                case 5:
                    Spawn4Node3Edge(spawnInfo);
                    break;
                case 6:
                    Spawn4Node5Edge(spawnInfo);
                    break;

            }
        }
        else
        {
            switch (inType)
            {
                case type_node_edge.type_1node0edge:
                    Spawn1Node0Edge(spawnInfo);
                    break;
                case type_node_edge.type_2node1edge:
                    Spawn2Node1Edge(spawnInfo);
                    break;
                case type_node_edge.type_3node3edge:
                    Spawn3Node3Edge(spawnInfo);
                    break;
                case type_node_edge.type_3node2edge:
                    Spawn3Node2Edge(spawnInfo);
                    break;
                case type_node_edge.type_4node4edge:
                    Spawn4Node4Edge(spawnInfo);
                    break;
                case type_node_edge.type_4node3edge:
                    Spawn4Node3Edge(spawnInfo);
                    break;
                case type_node_edge.type_4node5edge:
                    Spawn4Node5Edge(spawnInfo);
                    break;
                case type_node_edge.type_4node6edge2occupy:
                    Spawn4Node6Edge2Occupy(spawnInfo);
                    break;
                case type_node_edge.type_4node4edge2occupy:
                    Spawn4Node4Edge2Occupy(spawnInfo);
                    break;
                case type_node_edge.type_4node3edge3occupy:
                    Spawn4Node3Edge3Occupy(spawnInfo);
                    break;
                case type_node_edge.type_4node3edge2occupy:
                    Spawn4Node3Edge2Occupy(spawnInfo);
                    break;
                case type_node_edge.type_4node3edge2occupy1:
                    Spawn4Node3Edge2Occupy1(spawnInfo);
                    break;
                case type_node_edge.type_4node3edge2occupy2:
                    Spawn4Node3Edge2Occupy2(spawnInfo);
                    break;
                case type_node_edge.type_3node2edge2occupy:
                    Spawn3Node2Edge2Occupy(spawnInfo);
                    break;
                case type_node_edge.type_3node2edge1occupy:
                    Spawn3Node2Edge1Occupy(spawnInfo);
                    break;
                case type_node_edge.type_3node3edge2occupy:
                    Spawn3Node3Edge2Occupy(spawnInfo);
                    break;
                case type_node_edge.type_3node3edge1occupy:
                    Spawn3Node3Edge1Occupy(spawnInfo);
                    break;
                case type_node_edge.type_2node1edge1occupy:
                    Spawn2Node1Edge1Occupy(spawnInfo);
                    break;

            }

        }

        //
        // spawn Loop Enter object and give initial parameters.
        //

        GameObject loopEnter = Instantiate(loopEnterPrefab);

        LoopEnterComponent loopEnterComponent = loopEnter.GetComponent<LoopEnterComponent>();
        LoopComponent lc = loop.GetComponent<LoopComponent>();

        loopEnterComponent.SetLoop(lc.GetLoop());

        Transform tr = loopEnter.GetComponent<Transform>();
        tr.position.Set(pos.x, pos.y, 0);

        LoopEnterComponent loopEnterComp = loopEnter.GetComponent<LoopEnterComponent>();
        loopEnterComp.SetSpawnInfo(spawnInfo);

    }

    void SpawnCheck()
    {
        spawnTimer += Time.deltaTime;

        if(spawnTimer >= 3.0f)
        {
            Spawn(type_node_edge.random);

            spawnTimer = 0.0f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        //
        // Spawning
        //
        // SpawnCheck();

    }

    /*
                    public void RegenerateOne()
                    {

                        LoopComponent lc = loop.GetComponent<LoopComponent>();
                        lc.typeLoop = type_loop.one;

                    }

                    public void RegenerateTwo()
                    {

                        LoopComponent lc = loop.GetComponent<LoopComponent>();
                        lc.typeLoop = type_loop.two;

                    }

                    public void RegenerateThree()
                    {

                        LoopComponent lc = loop.GetComponent<LoopComponent>();
                        lc.typeLoop = type_loop.three;

                    }

                    public void RegenerateFour()
                    {

                        LoopComponent lc = loop.GetComponent<LoopComponent>();
                        lc.typeLoop = type_loop.four;

                    }

                    public void RegenerateFive()
                    {

                        LoopComponent lc = loop.GetComponent<LoopComponent>();
                        lc.typeLoop = type_loop.five;

                    }

                    public void RegenerateSix()
                    {

                        LoopComponent lc = loop.GetComponent<LoopComponent>();
                        lc.typeLoop = type_loop.six;

                    }
                */
    /*
public void drawOne()
{
LoopComponent lc = loop.GetComponent<LoopComponent>();
lc.AddEdgseNodesOne();
}

public void drawTwo()
{
LoopComponent lc = loop.GetComponent<LoopComponent>();
lc.AddEdgseNodesTwo();
}

public void drawThree()
{
LoopComponent lc = loop.GetComponent<LoopComponent>();
lc.AddEdgseNodesThree();
}

public void drawFour()
{
LoopComponent lc = loop.GetComponent<LoopComponent>();
lc.AddEdgseNodesFour();
}

public void drawFive()
{
LoopComponent lc = loop.GetComponent<LoopComponent>();
lc.AddEdgseNodesFive();
}

public void drawSix()
{
LoopComponent lc = loop.GetComponent<LoopComponent>();
lc.AddEdgseNodesSix();
}

public void draw()
{
if (loop == null)
{
return;
}

int number = (int)Random.Range(1.0f, 6.0f);

number = 4;
switch (number)
{
case 1:
    drawOne();
    break;
case 2:
    drawTwo();
    break;
case 3:
    drawThree();
    break;
case 4:
    drawFour();
    break;
case 5:
    drawFive();
    break;
case 6:
    drawSix();
    break;
}
}
*/

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public void RegenerateOne()
    {
        if (loop == null)
        {
            loop = Instantiate(loopPrefab, new Vector3(0.0f, -3.0f, 0.0f), Quaternion.identity);
        }

        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.typeLoop = type_loop.one;

    }

    public void RegenerateTwo()
    {
        if (loop == null)
        {
            loop = Instantiate(loopPrefab, new Vector3(0.0f, -3.0f, 0.0f), Quaternion.identity);
        }

        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.typeLoop = type_loop.two;

    }

    public void RegenerateThree()
    {
        if (loop == null)
        {
            loop = Instantiate(loopPrefab, new Vector3(0.0f, -3.0f, 0.0f), Quaternion.identity);
        }

        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.typeLoop = type_loop.three;

    }

    public void RegenerateFour()
    {
        if (loop == null)
        {
            loop = Instantiate(loopPrefab, new Vector3(0.0f, -3.0f, 0.0f), Quaternion.identity);
        }

        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.typeLoop = type_loop.four;

    }

    public void RegenerateFive()
    {
        if (loop == null)
        {
            loop = Instantiate(loopPrefab, new Vector3(0.0f, -3.0f, 0.0f), Quaternion.identity);
        }

        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.typeLoop = type_loop.five;

    }

    public void RegenerateSix()
    {
        if (loop == null)
        {
            loop = Instantiate(loopPrefab, new Vector3(0.0f, -3.0f, 0.0f), Quaternion.identity);
        }

        LoopComponent lc = loop.GetComponent<LoopComponent>();
        lc.typeLoop = type_loop.six;

    }

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

    // Start is called before the first frame update
    void Start()
    {
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

    void Spawn()
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

        int typeToGenerate = Random.Range(0, 4);
        switch( typeToGenerate)
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
//                Spawn3Node2Edge(spawnInfo);
                break;

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
            Spawn();

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
        SpawnCheck();

    }
}

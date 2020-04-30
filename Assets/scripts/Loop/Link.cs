using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link
{
    int[,] nodesMatrix;
    int numOfDim;

    //
    // Create a link in specified dimension.
    // and initialize it.
    //
    public Link( int inNumOfNodes )
    {
        setupLink(inNumOfNodes );
    }

    public void makeLink( int inRowIndex, int inColumnIndex)
    {
        nodesMatrix[inRowIndex, inColumnIndex] = 1;
    }

    public void clearLink(int inRowIndex, int inColumnIndex)
    {
        nodesMatrix[inRowIndex, inColumnIndex] = 0;
    }

    public void setupLink(int inNumOfNodes )
    {
        nodesMatrix = new int[inNumOfNodes, inNumOfNodes];
        numOfDim = inNumOfNodes;

        initializeLink(inNumOfNodes);
    }

    //
    // Create edges at random.
    //
    public Link( int inNumOfNodes, int inNumOfEdges )
    {
        setupLink(inNumOfNodes, inNumOfEdges );
    }

    public void setupLink(int inNumOfNodes, int inNumOfEdges )
    {
        nodesMatrix = new int[inNumOfNodes, inNumOfNodes];
        numOfDim = inNumOfNodes;

        initializeLink(inNumOfNodes);

        int maxNumOfEdges = (inNumOfNodes * inNumOfNodes - inNumOfNodes) / 2;
        int[] rows = new int[maxNumOfEdges];
        int[] columns = new int[maxNumOfEdges];

        int idx = 0;
        for ( int i = 0; i < inNumOfNodes - 1; i++)
        {
            for( int j = i; j < inNumOfNodes - 1; j++)
            {
                rows[idx] = i;
                columns[idx] = j;
                idx++;
            }
        }

        for ( int i = 0; i < inNumOfEdges; i++)
        {
            int rnd = (int)Random.Range(0.0f, idx -1 );

            nodesMatrix[rows[rnd], columns[rnd]] = 1;

            rows[rnd] = rows[idx-1 ];
            columns[rnd] = columns[idx-1];
            idx--;
        }
    }



    public Link( type_loop typeLoop)
    {
        switch( typeLoop)
        {
            case type_loop.one:
                setupLinkOne();
                break;
            case type_loop.two:
                setupLinkTwo();
                break;
            case type_loop.three:
                setupLinkThree();
                break;
            case type_loop.four:
                setupLinkFour();
                break;
            case type_loop.five:
                setupLinkFive();
                break;
            case type_loop.six:
                setupLinkSix();
                break;
        }

    }

    public void initializeLink( int dimension )
    {
        for( int i = 0; i < dimension; i++)
        {
            for( int j = 0; j < dimension; j++)
            {
                nodesMatrix[i, j] = 0;
            }
        }
    }

    public void setupLinkOne()
    {
        nodesMatrix = new int[2,2];
        numOfDim = 2;

        initializeLink(2);

        nodesMatrix[0,1] = 1;
        nodesMatrix[1,0] = 1;
    }

    public void setupLinkTwo()
    {
        nodesMatrix = new int[3, 3];
        numOfDim = 3;

        initializeLink(3);

        nodesMatrix[0, 1] = 1;
        nodesMatrix[0, 2] = 1;
        nodesMatrix[1, 0] = 1;
        nodesMatrix[1, 2] = 1;
        nodesMatrix[2, 0] = 1;
        nodesMatrix[2, 1] = 1;
    }

    public void setupLinkThree()
    {
        nodesMatrix = new int[3, 3];
        numOfDim = 3;

        initializeLink(3);

        nodesMatrix[0, 1] = 1;
        nodesMatrix[0, 2] = 1;
        nodesMatrix[1, 0] = 1;
        nodesMatrix[2, 0] = 1;
    }

    public void setupLinkFour()
    {
        nodesMatrix = new int[4, 4];
        numOfDim = 4;

        initializeLink(4);

        nodesMatrix[0, 1] = 1;
        nodesMatrix[0, 3] = 1;

        nodesMatrix[1, 0] = 1;
        nodesMatrix[1, 2] = 1;

        nodesMatrix[2, 1] = 1;
        nodesMatrix[2, 3] = 1;

        nodesMatrix[3, 0] = 1;
        nodesMatrix[3, 2] = 1;
    }

    public void setupLinkFive()
    {
        nodesMatrix = new int[4, 4];
        numOfDim = 4;

        initializeLink(4);

        nodesMatrix[0, 1] = 1;
        nodesMatrix[0, 2] = 1;
        nodesMatrix[0, 3] = 1;
        nodesMatrix[1, 0] = 1;
        nodesMatrix[2, 0] = 1;
        nodesMatrix[3, 0] = 1;
    }

    public void setupLinkSix()
    {
        nodesMatrix = new int[4, 4];
        numOfDim = 4;

        initializeLink(4);

        nodesMatrix[0, 1] = 1;
        nodesMatrix[0, 2] = 1;
        nodesMatrix[0, 3] = 1;

        nodesMatrix[1, 0] = 1;
        nodesMatrix[1, 2] = 1;

        nodesMatrix[2, 0] = 1;
        nodesMatrix[2, 1] = 1;
        nodesMatrix[2, 3] = 1;

        nodesMatrix[3, 0] = 1;
        nodesMatrix[3, 2] = 1;

    }

    public bool isLinkPresent(int row, int column)
    {
        if( nodesMatrix[row,column] == 1)
        {
            return true;
        }
        else
        {
            return false;
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
}

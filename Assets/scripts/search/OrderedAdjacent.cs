using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderedAdjacent
{
    Edge[,] edges;
    List<Node> nodes;
    int numOfNodes;

    Stack<int> openList = new Stack<int>();
    List<int> closedList = new List<int>();

    List<List<int>> resultPathList = new List<List<int>>();

    const int NO_MORE_PARENT = -1;

    public OrderedAdjacent(Edge[,] inEdges, List<Node> inNodes, int inNumOfNodes )
    {
        edges = inEdges;
        nodes = inNodes;
        numOfNodes = inNumOfNodes;
    }

    public List<List<int>> findPath( Node inStartNode )
    {
        openList.Clear();
        closedList.Clear();
        resultPathList.Clear();

        inStartNode.SetParentNodeIndex(NO_MORE_PARENT);
        inStartNode.SetCost(0.0f);
        openList.Push(inStartNode.getNodeIndex());

        //        Debug.Log("start node:"+inStartNode.getNodeValue());


        while ( openList.Count != 0)
        {
            int currentNodeIndex = openList.Pop();
//            openList.Remove(currentNodeIndex);

            closedList.Add(currentNodeIndex);

            List<int> successorNodeIndecies = GetSuccessorNodes( edges, nodes, numOfNodes, currentNodeIndex);
            bool deadEndFlg = true;

            if (successorNodeIndecies.Count == 0)
            {
                closedList.Add(currentNodeIndex);
            }
            else
            {
                foreach (int successorNode in successorNodeIndecies)
                {
                    Node currentNode = nodes[currentNodeIndex];
                    type_node_value currentNodeValue = currentNode.getNodeValue();

                    Node tempNode = nodes[successorNode];
                    type_node_value tempNodeValue = tempNode.getNodeValue();

                    // both must be numerial nodes.
                    if (currentNodeValue == type_node_value.type_node_value_empty || 
                        tempNodeValue == type_node_value.type_node_value_empty) {
                        continue;
                    }
                    
                    if (tempNodeValue - currentNodeValue == 1)
                    {
                        //
                        // calculate cost
                        //
                        float tempCost = nodes[currentNodeIndex].GetCost();
                        tempCost += 1.0f;

                        //
                        // add successorNode to open list.
                        //
                        nodes[successorNode].SetParentNodeIndex(currentNodeIndex);

                        if( false == openList.Contains( successorNode ) || tempCost > nodes[successorNode].GetCost() )
                        {
                            nodes[successorNode].SetCost(tempCost);
                            openList.Push(successorNode);
                        }
//                      Debug.Log("->node:" + inNodes[successorNode].getNodeValue());

                        deadEndFlg = false;
                    }

                }
            }

            if (deadEndFlg == true) {

                //
                // one path has been created.
                //

                List<int> resultPath = generateResultPath(currentNodeIndex, nodes);
                resultPathList.Add(resultPath);

            }

        }

        return resultPathList;

    }

    List<int> generateResultPath(int inNodeIndex, List<Node> inNodes)
    {

        List<int> resultPath = new List<int>();

        int nodeIndex = inNodeIndex;

        do{
            resultPath.Insert(0, nodeIndex);
            nodeIndex = inNodes[nodeIndex].GetParentNodeIndex();

        } while (nodeIndex != NO_MORE_PARENT);

        debugLog(resultPath, inNodes);
        return resultPath;
    }

    void debugLog( List<int> inPath, List<Node> inNodes )
    {
        int pathLength = inPath.Count;
        if( pathLength == 0)
        {
            return;
        }

        string pathStr = "";
        for( int pathIndex = 0; pathIndex < pathLength; pathIndex++)
        {
            int nodeIndex = inPath[pathIndex];
            type_node_value nodeValue = nodes[nodeIndex].getNodeValue();
            pathStr = pathStr + "->" + nodeValue;
        }

        Debug.Log(pathStr);

    }

    List<int> GetSuccessorNodes(Edge[,] inEdges, List<Node> inNodes, int inNumOfNodes, int inCurrentNodeIndex)
    {
        List<int> successorNodes = new List<int>();

        for( int column = 0; column < inNumOfNodes; column++)
        {
            if( inCurrentNodeIndex == column)
            {
                continue;
            }

            Edge tempEdge1;
            Edge tempEdge2;
            tempEdge1 = inEdges[column, inCurrentNodeIndex];
            tempEdge2 = inEdges[inCurrentNodeIndex, column];

            if (tempEdge1 != null || tempEdge2 != null )
            {
                if(false == closedList.Contains(column) )
                {
                    int nodeIndex = column;
                    successorNodes.Add(nodeIndex);
                }
            }

        }

        return successorNodes;

    }


}

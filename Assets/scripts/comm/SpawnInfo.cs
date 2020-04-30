using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInfo
{

    // screen absolute position.
    Vector2 position;

    // relative position.
    Vector2 rPosition;

    // current position for display.
    Vector2 currentPosition;

    // variable for interpolation.
    float t;

    // list of node ids.
    List<int> nodes;

    public SpawnInfo()
    {
        nodes = new List<int>();

        t = 0.0f;
    }

    public Vector2 GetCurrentPosition()
    {
        return currentPosition;
    }

    public void SetCurrentPosition( Vector2 inCurrentPosition)
    {
        currentPosition = inCurrentPosition;
    }

    public void SetT( float inT )
    {
        t = inT;
    }

    public float GetT()
    {
        return t;
    }

    public List<int> GetNodeIndecies()
    {
        return nodes;
    }

    public void AddNodeIndex( int inNodeIndex )
    {
        nodes.Add(inNodeIndex);
    }

    public void SetPosition( Vector2 inPos)
    {
        position = inPos;
    }

    public Vector2 GetPosition()
    {
        return position;
    }

    public void SetRPosition(Vector2 inRPos)
    {
        rPosition = inRPos;
    }

    public Vector2 GetRPosition()
    {
        return rPosition;
    }

}

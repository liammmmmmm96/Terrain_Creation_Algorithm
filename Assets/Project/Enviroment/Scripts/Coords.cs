using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coords
{

    //Pos
    public int x;
    public int y;

    public int m_gCost; //distance from start
    public int m_hCost; //distance if not account for  blockers
    public int m_fCost; //fcost distance to node

    //coord data
    public Coords LastCoord;
    public bool IsWalkable;
    public bool IsWater;
    public Coords(int x, int y)
    {
        this.x = x;
        this.y = y;
        IsWalkable = true;
        LastCoord = null;
    }
    public void CalculateFCost() //movement cost
    {
        m_fCost = m_gCost + m_hCost;
    }



}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNode
{
    GridPosition gridPosition;
    int gCost;
    int hCost;
    int fCost;
    PathNode cameFromPathNode;
    bool isWalkable = true;

    public PathNode(GridPosition gridPosition)
    {
        this.gridPosition = gridPosition;
    }

    public void SetGCost(int gCost)
    {
        this.gCost = gCost;
    }

    public void SetHCost(int hCost)
    {
        this.hCost = hCost;
    }

    public void CalculateFCost()
    {
        fCost = gCost + hCost;
    }

    public void ResetCameFromPathNode()
    {
        cameFromPathNode = null;
    }

    public void SetCameFromPathNode(PathNode pathNode)
    {
        cameFromPathNode = pathNode;
    }

    public void SetIsWalkable(bool isWalkable)
    {
        this.isWalkable = isWalkable;
    }

    public override string ToString() => gridPosition.ToString();

    public int GetGCost() => gCost;

    public int GetHCost() => hCost;

    public int GetFCost() => fCost;

    public PathNode GetCameFromPathNode() => cameFromPathNode;

    public GridPosition GetGridPosition() => gridPosition;

    public bool IsWalkable() => isWalkable;
}

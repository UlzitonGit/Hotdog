using UnityEngine;

public abstract class Hotdog
{
    protected string name;
    protected int cost;
    protected int weight;
    
    public virtual string GetName() => name;
    public virtual int GetCost() => cost;
    public virtual int GetWeight() => weight;
}
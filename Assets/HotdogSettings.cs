using UnityEngine;

[CreateAssetMenu(fileName = "HotdogSettings", menuName = "Hotdog/Settings")]
public class HotdogSettings : ScriptableObject
{
    public string hotdogName;
    public int baseCost;
    public int baseWeight; 
    public int pickleCost = 50;
    public int pickleWeight = 20;
    public int sweetOnionCost = 30;
    public int sweetOnionWeight = 10;
}

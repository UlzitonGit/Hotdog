using UnityEngine;

public class HotdogManager : MonoBehaviour
{

    public HotdogSettings classicSettings;
    public HotdogSettings cheeseSettings;
    public HotdogSettings baconSettings;
    
    private void Start()
    {
        DebugHotdog(classicSettings);
        DebugHotdog(cheeseSettings);
        DebugHotdog(baconSettings);
    }
    
    private void DebugHotdog(HotdogSettings settings)
    {
        Hotdog baseHotdog = CreateHotdogByType(settings);
        
        string result = $"{baseHotdog.GetName()} ({baseHotdog.GetWeight()}г) — {baseHotdog.GetCost()}р.\n";
        
        Hotdog withPickle = new PickleDecorator(baseHotdog, settings);
        result += $"{withPickle.GetName()} ({withPickle.GetWeight()}г) — {withPickle.GetCost()}р.\n";
        
        Hotdog withOnion = new SweetOnionDecorator(baseHotdog, settings);
        result += $"{withOnion.GetName()} ({withOnion.GetWeight()}г) — {withOnion.GetCost()}р.";
        
        Debug.Log(result);
    }
    
    private Hotdog CreateHotdogByType(HotdogSettings settings)
    {
        if (settings.hotdogName.Contains("классический"))
            return new ClassicHotdog(settings);
        else if (settings.hotdogName.Contains("сырный"))
            return new CheeseHotdog(settings);
        else if (settings.hotdogName.Contains("бекон"))
            return new BaconHotdog(settings);
        else
            return new ClassicHotdog(settings);
    }
}
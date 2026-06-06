public class ClassicHotdog : Hotdog
{
    public ClassicHotdog(HotdogSettings settings)
    {
        name = settings.hotdogName;
        cost = settings.baseCost;
        weight = settings.baseWeight;
    }
}

public class CheeseHotdog : Hotdog
{
    public CheeseHotdog(HotdogSettings settings)
    {
        name = settings.hotdogName;
        cost = settings.baseCost;
        weight = settings.baseWeight;
    }
}

public class BaconHotdog : Hotdog
{
    public BaconHotdog(HotdogSettings settings)
    {
        name = settings.hotdogName;
        cost = settings.baseCost;
        weight = settings.baseWeight;
    }
}
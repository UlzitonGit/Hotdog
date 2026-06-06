public abstract class HotdogDecorator : Hotdog
{
    protected Hotdog decoratedHotdog;
    protected HotdogSettings settings;
    
    public HotdogDecorator(Hotdog hotdog, HotdogSettings settings)
    {
        decoratedHotdog = hotdog;
        this.settings = settings;
    }
    
    public override string GetName() => decoratedHotdog.GetName();
    public override int GetCost() => decoratedHotdog.GetCost();
    public override int GetWeight() => decoratedHotdog.GetWeight();
}


public class PickleDecorator : HotdogDecorator
{
    public PickleDecorator(Hotdog hotdog, HotdogSettings settings) : base(hotdog, settings) { }
    
    public override string GetName() => decoratedHotdog.GetName() + " с маринованными огурцами";
    
    public override int GetCost() => decoratedHotdog.GetCost() + settings.pickleCost;
    
    public override int GetWeight() => decoratedHotdog.GetWeight() + settings.pickleWeight;
}

public class SweetOnionDecorator : HotdogDecorator
{
    public SweetOnionDecorator(Hotdog hotdog, HotdogSettings settings) : base(hotdog, settings) { }
    
    public override string GetName() => decoratedHotdog.GetName() + " с сладким луком";
    
    public override int GetCost() => decoratedHotdog.GetCost() + settings.sweetOnionCost;
    
    public override int GetWeight() => decoratedHotdog.GetWeight() + settings.sweetOnionWeight;
}
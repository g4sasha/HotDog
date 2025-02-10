namespace HotDogs
{
    public class HotdogWithSweetOnion : HotdogDecorator
    {
        public HotdogWithSweetOnion(Hotdog hotdog) : base(hotdog) { }
        public override int GetCost() => _hotdog.GetCost() + 30;
        public override string GetName() => _hotdog.GetName() + " с сладким луком";
    }
}

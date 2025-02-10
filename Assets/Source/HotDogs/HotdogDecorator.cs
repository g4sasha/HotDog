namespace HotDogs
{
    public abstract class HotdogDecorator : Hotdog
    {
        protected readonly Hotdog _hotdog;
        public HotdogDecorator(Hotdog hotdog) : base(hotdog.GetName()) => _hotdog = hotdog;
        public override int GetCost() => _hotdog.GetCost();
    }
}

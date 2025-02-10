namespace HotDogs
{
    public class HotdogWithPickles : HotdogDecorator
    {
        public HotdogWithPickles(Hotdog hotdog) : base(hotdog) { }
        public override int GetCost() => _hotdog.GetCost() + 50;
        public override string GetName() => _hotdog.GetName() + " с маринованными огурцами";
    }
}

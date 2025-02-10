using UnityEngine;

namespace HotDogs
{
    public class HotdogWithSweetOnion : HotdogDecorator
    {
        private static readonly HotdogDecoratorSO _config = Resources.Load<HotdogDecoratorSO>("HotdogWithSweetOnionConfig");
        public HotdogWithSweetOnion(Hotdog hotdog) : base(hotdog) { }
        public override int GetCost() => _hotdog.GetCost() + _config.AdditionalCost;
        public override int GetWeight() => _hotdog.GetWeight() + _config.AdditionalWeight;
        public override string GetName() => _hotdog.GetName() + " " + _config.DecoratorSuffix;
    }
}

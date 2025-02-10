using UnityEngine;

namespace HotDogs
{
    public class HotdogWithPickles : HotdogDecorator
    {
        private static readonly HotdogDecoratorSO _config = Resources.Load<HotdogDecoratorSO>("HotdogWithPicklesConfig");
        public HotdogWithPickles(Hotdog hotdog) : base(hotdog) { }
        public override int GetCost() => _hotdog.GetCost() + _config.AdditionalCost;
        public override int GetWeight() => _hotdog.GetWeight() + _config.AdditionalWeight;
        public override string GetName() => _hotdog.GetName() + " " + _config.DecoratorSuffix;
    }
}

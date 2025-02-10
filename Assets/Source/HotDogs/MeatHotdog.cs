using UnityEngine;

namespace HotDogs
{
    public class MeatHotdog : Hotdog
    {
        private static readonly HotdogConfig _config = Resources.Load<HotdogConfig>("MeatHotdogConfig");
        public MeatHotdog() : base(_config.HotdogName) { }
        public override int GetCost() => _config.Cost;
        public override int GetWeight() => _config.Weight;
    }
}

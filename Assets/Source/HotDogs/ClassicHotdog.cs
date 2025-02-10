using UnityEngine;

namespace HotDogs
{
    public class ClassicHotdog : Hotdog
    {
        private static readonly HotdogConfig _config = Resources.Load<HotdogConfig>("ClassicHotdogConfig");
        public ClassicHotdog() : base(_config.HotdogName) { }
        public override int GetCost() => _config.Cost;
        public override int GetWeight() => _config.Weight;
    }
}

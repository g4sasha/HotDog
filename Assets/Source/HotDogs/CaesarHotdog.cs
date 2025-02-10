using UnityEngine;

namespace HotDogs
{
    public class CaesarHotdog : Hotdog
    {
        private static readonly HotdogConfig _config = Resources.Load<HotdogConfig>("CaesarHotdogConfig");
        public CaesarHotdog() : base(_config.HotdogName) { }
        public override int GetCost() => _config.Cost;
        public override int GetWeight() => _config.Weight;
    }
}

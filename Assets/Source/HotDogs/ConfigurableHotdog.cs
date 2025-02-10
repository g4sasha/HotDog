namespace HotDogs
{
    public class ConfigurableHotdog : Hotdog
    {
        private readonly HotdogSO _config;
        public ConfigurableHotdog(HotdogSO config) : base(config.HotdogName) => _config = config;
        public override int GetCost() => _config.Cost;
        public override int GetWeight() => _config.Weight;
    }
}

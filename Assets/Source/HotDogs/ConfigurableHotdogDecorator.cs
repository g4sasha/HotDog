namespace HotDogs
{
    public class ConfigurableHotdogDecorator : HotdogDecorator
    {
        private readonly HotdogDecoratorSO _config;
        public ConfigurableHotdogDecorator(Hotdog hotdog, HotdogDecoratorSO config) : base(hotdog) => _config = config;
        public override int GetCost() => _hotdog.GetCost() + _config.AdditionalCost;
        public override int GetWeight() => _hotdog.GetWeight() + _config.AdditionalWeight;
        public override string GetName() => _hotdog.GetName() + " " + _config.DecoratorSuffix;
    }
}

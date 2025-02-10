namespace HotDogs
{
    public abstract class Hotdog
    {
        private readonly string _name;
        public Hotdog(string name) => _name = name;
        public virtual string GetName() => _name;
        public abstract int GetCost();
    }
}

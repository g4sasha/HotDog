namespace HotDogs
{
    public class MeatHotdog : Hotdog
    {
        public MeatHotdog() : base("Хот-дог мясной") { }
        public override int GetCost() => 330;
    }
}

namespace HotDogs
{
    public class ClassicHotdog : Hotdog
    {
        public ClassicHotdog() : base("Хот-дог классический") { }
        public override int GetCost() => 210;
    }
}

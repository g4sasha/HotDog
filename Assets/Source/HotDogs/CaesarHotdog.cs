namespace HotDogs
{
    public class CaesarHotdog : Hotdog
    {
        public CaesarHotdog() : base("Хот-дог цезарь") { }
        public override int GetCost() => 290;
    }
}

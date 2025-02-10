using UnityEngine;

namespace HotDogs
{
    [CreateAssetMenu(fileName = "HotdogConfig", menuName = "HotDogs/HotdogConfig")]
    public class HotdogConfig : ScriptableObject
    {
        public string HotdogName;
        public int Cost;
        public int Weight;
    }
}

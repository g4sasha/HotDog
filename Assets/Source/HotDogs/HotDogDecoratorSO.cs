using UnityEngine;

namespace HotDogs
{
    [CreateAssetMenu(fileName = "HotdogDecoratorConfig", menuName = "HotDogs/HotdogDecoratorConfig")]
    public class HotdogDecoratorSO : ScriptableObject
    {
        public string DecoratorSuffix;
        public int AdditionalCost;
        public int AdditionalWeight;
    }
}

using UnityEngine;

namespace HotDogs
{
    [CreateAssetMenu(fileName = "HotdogDecoratorConfig", menuName = "HotDogs/HotdogDecoratorConfig")]
    public class HotdogDecoratorSO : ScriptableObject
    {
        [field: SerializeField] public string DecoratorSuffix { get; private set; }
        [field: SerializeField] public int AdditionalCost { get; private set; }
        [field: SerializeField] public int AdditionalWeight { get; private set; }
    }
}

using UnityEngine;

namespace HotDogs
{
    [CreateAssetMenu(fileName = "HotdogConfig", menuName = "HotDogs/HotdogConfig")]
    public class HotdogSO : ScriptableObject
    {
        [field: SerializeField] public string HotdogName { get; private set; }
        [field: SerializeField] public int Cost { get; private set; }
        [field: SerializeField] public int Weight { get; private set; }
    }
}

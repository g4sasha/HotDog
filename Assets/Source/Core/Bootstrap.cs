using HotDogs;
using UnityEngine;

namespace Core
{
    public class Bootstrab : MonoBehaviour
    {
        private void Start()
        {
            Hotdog classicHotdog = new ClassicHotdog();
            Debug.Log($"{classicHotdog.GetName()} — {classicHotdog.GetCost()}р.");
            Debug.Log("Дополнительная информация:");

            Hotdog classicWithPickles = new HotdogWithPickles(new ClassicHotdog());
            Debug.Log($"{classicWithPickles.GetName()} — {classicWithPickles.GetCost()}р.");

            Hotdog classicWithSweetOnion = new HotdogWithSweetOnion(new ClassicHotdog());
            Debug.Log($"{classicWithSweetOnion.GetName()} — {classicWithSweetOnion.GetCost()}р.");
        }
    }
}

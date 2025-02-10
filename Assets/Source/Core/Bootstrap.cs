using HotDogs;
using UnityEngine;

namespace Core
{
    public class Bootstrab : MonoBehaviour
    {
        private void Start()
        {
            Hotdog[] baseHotdogs = new Hotdog[]
            {
                new ClassicHotdog(),
                new CaesarHotdog(),
                new MeatHotdog()
            };

            foreach (var hotdog in baseHotdogs)
            {
                Debug.Log($"{hotdog.GetName()} ({hotdog.GetWeight()}г) — {hotdog.GetCost()}р.");
                Debug.Log("Дополнительная информация:");
                Hotdog withPickles = new HotdogWithPickles(hotdog);
                Debug.Log($"{withPickles.GetName()} ({withPickles.GetWeight()}г) — {withPickles.GetCost()}р.");
                Hotdog withSweetOnion = new HotdogWithSweetOnion(hotdog);
                Debug.Log($"{withSweetOnion.GetName()} ({withSweetOnion.GetWeight()}г) — {withSweetOnion.GetCost()}р.");
            }
        }
    }
}

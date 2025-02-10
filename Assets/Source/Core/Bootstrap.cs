using HotDogs;
using UnityEngine;

namespace Core
{
    public class Bootstrab : MonoBehaviour
    {
        private void Start()
        {
            HotdogSO classicConfig = Resources.Load<HotdogSO>("ClassicHotdogConfig");
            HotdogSO caesarConfig = Resources.Load<HotdogSO>("CaesarHotdogConfig");
            HotdogSO meatConfig = Resources.Load<HotdogSO>("MeatHotdogConfig");

            HotdogDecoratorSO picklesConfig = Resources.Load<HotdogDecoratorSO>("HotdogWithPicklesConfig");
            HotdogDecoratorSO sweetOnionConfig = Resources.Load<HotdogDecoratorSO>("HotdogWithSweetOnionConfig");

            Hotdog[] baseHotdogs = new Hotdog[]
            {
                new ConfigurableHotdog(classicConfig),
                new ConfigurableHotdog(caesarConfig),
                new ConfigurableHotdog(meatConfig)
            };

            foreach (Hotdog hotdog in baseHotdogs)
            {
                Debug.Log("==========");

                Debug.Log($"{hotdog.GetName()} ({hotdog.GetWeight()}г) — {hotdog.GetCost()}р.");
                Debug.Log("Дополнительная информация:");

                Hotdog hotdogWithPickles = new ConfigurableHotdogDecorator(hotdog, picklesConfig);
                Debug.Log($"{hotdogWithPickles.GetName()} ({hotdogWithPickles.GetWeight()}г) — {hotdogWithPickles.GetCost()}р.");

                Hotdog hotdogWithSweetOnion = new ConfigurableHotdogDecorator(hotdog, sweetOnionConfig);
                Debug.Log($"{hotdogWithSweetOnion.GetName()} ({hotdogWithSweetOnion.GetWeight()}г) — {hotdogWithSweetOnion.GetCost()}р.");
            }
        }
    }
}

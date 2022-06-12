using UnityEngine;


namespace MVVM
{
    internal sealed class Starter : MonoBehaviour
    {
        private void Start()
        {
            var hpModel = new HpModel(100);
            var hpViewModel = new HpViewModel(hpModel);
            FindObjectOfType<HpView>().Initialize(hpViewModel);
            FindObjectOfType<ApplyDamageView>().Initialize(hpViewModel);
        }
    }
}

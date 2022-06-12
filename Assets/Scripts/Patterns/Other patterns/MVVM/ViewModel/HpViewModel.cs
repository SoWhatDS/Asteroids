using System;


namespace MVVM
{
    internal sealed class HpViewModel : IHpViewModel
    {
        private bool _isDead;
        public IHpModel HpModel { get; }

        public bool IsDead => _isDead;

        public event Action<float> OnHpChange;

        public HpViewModel(IHpModel hpModel)
        {
            HpModel = hpModel;
        }

        public void ApplyDamage(float damage)
        {
            HpModel.CurrentHp -= damage;
            if (HpModel.CurrentHp <= 0)
            {
                _isDead = true;
            }
            OnHpChange?.Invoke(HpModel.CurrentHp);
        }
    }
}

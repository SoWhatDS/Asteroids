using UnityEngine;


namespace Asteroids
{
    internal sealed class ModificationMuffler : ModificationWeapon
    {
        private readonly AudioSource _audioSource;
        private readonly IMufflerDecorator _muffler;
        private readonly Vector3 _mufflerPosition;
        private GameObject _mufflerInstance;

        public ModificationMuffler(AudioSource audioSource,IMufflerDecorator muffler, Vector3 mufflerPosition)
        {
            _audioSource = audioSource;
            _muffler = muffler;
            _mufflerPosition = mufflerPosition;
        }

        protected override WeaponDecorator AddModification(WeaponDecorator weapon)
        {
            _mufflerInstance = Object.Instantiate(_muffler.MufflerInstance, _mufflerPosition, Quaternion.identity);
            _audioSource.volume = _muffler.VolumeFireOnMuffler;
            weapon.SetAudioClip(_muffler.AudioClipMuffler);
            weapon.SetBarrelPosition(_muffler.BarrelPositionMuffler);
            return weapon;
        }

        protected override WeaponDecorator RemoveModification(WeaponDecorator weapon)
        {
            return weapon;
        }
    }
}

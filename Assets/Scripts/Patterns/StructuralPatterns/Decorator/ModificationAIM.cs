using UnityEngine;


namespace Asteroids
{
    internal sealed class ModificationAIM : ModificationWeapon
    {
        private readonly AudioSource _audioSource;
        private readonly IAimDecorator _aim;
        private readonly Vector3 _aimPosition;
        private GameObject _aimInstance;

        public ModificationAIM(AudioSource audioSource, IAimDecorator aim, Vector3 aimPosition)
        {
            _audioSource = audioSource;
            _aim = aim;
            _aimPosition = aimPosition;
        }

        protected override WeaponDecorator AddModification(WeaponDecorator weapon)
        {
            _aimInstance = Object.Instantiate(_aim.AimInstance, _aimPosition, Quaternion.identity);
            _audioSource.volume = _aim.VolumeFireOnAim;
            weapon.SetAudioClip(_aim.AudioClipAim);          
            return weapon;
        }

        protected override WeaponDecorator RemoveModification(WeaponDecorator weapon)
        {
            GameObject.Destroy(_aimInstance);
            weapon.SetAudioClip(weapon.GetAudioClip());
            weapon.SetBarrelPosition(weapon.GetBarrelPosition());
            return weapon;
        }
    }
}

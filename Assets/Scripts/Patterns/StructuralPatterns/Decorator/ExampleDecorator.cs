using UnityEngine;

namespace Asteroids
{
    public class ExampleDecorator : MonoBehaviour
    {
        private IFireDecorator _fire;

        private ModificationWeapon _modificationWeaponMuffler;
        private ModificationWeapon _modificationWeaponAIM;
        private WeaponDecorator _weaponMuffler;    

        [Header("Start Gun")]
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrelPosition;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioClip _audioClip;

        [Header("Muffler Gun")]
        [SerializeField] private AudioClip _audioClipMuffler;
        [SerializeField] private float _volumeFireOnMuffler;
        [SerializeField] private Transform _barrelPositionMuffler;
        [SerializeField] private GameObject _muffler;

        [Header("AIM Gun")]
        [SerializeField] private AudioClip _audioClipAIM;
        [SerializeField] private float _volumeFireOnMufflerAIM;
        [SerializeField] private Transform _barrelPositioAIM;
        [SerializeField] private GameObject _aim;

        private void Start()
        {
            IAmmunitionDecorator ammunition = new BulletDecorator(_bullet, 3.0f);
            _weaponMuffler = new WeaponDecorator(ammunition, _barrelPosition, 1000000.0f, _audioSource, _audioClip);

            var muffler = new MufflerDecorator(_audioClipMuffler, _volumeFireOnMuffler, _barrelPosition, _muffler);
            _modificationWeaponMuffler = new ModificationMuffler(_audioSource, muffler, _barrelPositionMuffler.position);
            _modificationWeaponMuffler.ApplyModification(_weaponMuffler);

            _fire = _modificationWeaponMuffler;
           
            var aim = new AimDecorator(_audioClipAIM, _volumeFireOnMufflerAIM, _barrelPositioAIM, _aim);
            _modificationWeaponAIM = new ModificationAIM(_audioSource, aim, _barrelPositioAIM.position);
            _modificationWeaponAIM.ApplyModification(_weaponMuffler);

            _fire = _modificationWeaponAIM;

        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _fire.FireDecorator();
            }
            if (Input.GetMouseButtonDown(1))
            {
                _modificationWeaponMuffler.DeleteModification(_weaponMuffler);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                _modificationWeaponAIM.DeleteModification(_weaponMuffler);
            }
        }
    }

}

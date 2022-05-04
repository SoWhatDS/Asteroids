using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class WeaponDecorator : IFireDecorator
    {
        private Transform _barrelPosition;
        private IAmmunitionDecorator _bullet;
        private float _force;
        private AudioClip _audioClip;
        private readonly AudioSource _audioSource;

        public WeaponDecorator(IAmmunitionDecorator bullet, Transform barrelPosition, float force, AudioSource audioSource,
            AudioClip audioClip)
        {
            _bullet = bullet;
            _barrelPosition = barrelPosition;
            _force = force;
            _audioSource = audioSource;
            _audioClip = audioClip;
        }

        public void SetBarrelPosition(Transform barrelPosition)
        {
            _barrelPosition = barrelPosition;
        }

        public void SetBullet(IAmmunitionDecorator bullet)
        {
            _bullet = bullet;
        }

        public void SetForce(float force)
        {
            _force = force;
        }

        public void SetAudioClip(AudioClip audioClip)
        {
            _audioClip = audioClip;
        }

        public void FireDecorator()
        {
            var bullet = Object.Instantiate(_bullet.BulletInstance, _barrelPosition.position, Quaternion.identity);
            bullet.AddForce(_barrelPosition.forward * _force);
            Object.Destroy(bullet.gameObject, _bullet.TimeToDestroy);
            _audioSource.PlayOneShot(_audioClip);
        
        }

       
    }
}

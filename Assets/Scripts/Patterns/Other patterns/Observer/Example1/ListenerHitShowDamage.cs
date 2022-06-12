using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace Asteroids.Observer.Example1
{
    public sealed class ListenerHitShowdamage
    {
        private readonly List<IHit> _hits = new List<IHit>(8);

        public void Add(IHit value)
        {
            value.OnHitChange += ValueOnHitChange;
            _hits.Add(value);
        }

        public void Remove(IHit value)
        {
            var firstOrDefault = _hits.FirstOrDefault(_hit => _hit == value);
            firstOrDefault.OnHitChange -= ValueOnHitChange;
            _hits.Remove(firstOrDefault);
        }

        private void ValueOnHitChange(float damage)
        {
            Debug.Log(damage);

            Test += OnTest;
        }

        private void OnTest(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public event EventHandler Test;
    }
}

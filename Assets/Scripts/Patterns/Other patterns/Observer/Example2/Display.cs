using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Observer.Example2
{
    internal class Display : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private List<IDeath> _death;

        private void Add(IDeath death)
        {
            death.OnDeathChange += DeathOnDeathChange;
        }

        private void Remove(IDeath death)
        {
            death.OnDeathChange -= delegate { DeathOnDeathChange(death.Name);};
        }

        private void DeathOnDeathChange(string deathName)
        {
            _text.text = $"Умер {deathName}";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Asteroids.Interpretator
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private Text _text;
        [SerializeField] private InputField _inputField;

        private void Start()
        {
            _inputField.onValueChanged.AddListener(Interpret);
        }

        private void Interpret(string value)
        {
            if (int.TryParse(value, out var number))
            {              
                _text.text = Score(number);
            }
        }

        private string Score(long number)
        {
            
            if ((number < 0) || (number > long.MaxValue)) throw new ArgumentOutOfRangeException(nameof(number),"Number is not in value range");
            if (number < 1000) return string.Empty;
            if (number >= 1000 && number < 1000000) return number/1000 + "K";
            if (number >= 1000000 && number < 1000000000) return number / 1000000 + "M";
            throw new ArgumentOutOfRangeException(nameof(number));            

        }
    }
}
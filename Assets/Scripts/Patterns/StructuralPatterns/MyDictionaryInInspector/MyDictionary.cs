using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeWork6
{
    public sealed class MyDictionary : MonoBehaviour,ISerializationCallbackReceiver
    {
        [SerializeField] private DictionaryScriptableObject _dictionaryData;

        [SerializeField] private List<string> _keys = new List<string>();
        [SerializeField] private List<int> _values = new List<int>();
        public bool _modifyValues;

        private Dictionary<string, int> _myDictionary = new Dictionary<string, int>();


        private void Awake()
        {
            for (int i = 0; i < Mathf.Min(_dictionaryData.Keys.Count, _dictionaryData.Values.Count); i++)
            {
                _myDictionary.Add(_dictionaryData.Keys[i], _dictionaryData.Values[i]);
            }
        }
        public void OnAfterDeserialize()
        {
           
        }

        public void OnBeforeSerialize()
        {
            if (_modifyValues == false)
            {
                _keys.Clear();
                _values.Clear();
                for (int i = 0; i < Mathf.Min(_dictionaryData.Keys.Count, _dictionaryData.Values.Count); i++)
                {
                    _keys.Add(_dictionaryData.Keys[i]);
                    _values.Add(_dictionaryData.Values[i]);
                }
            }          
        }

        public void DeserializeDictionary()
        {
            Debug.Log("Deserialization");
            _myDictionary = new Dictionary<string, int>();
            _dictionaryData.Keys.Clear();
            _dictionaryData.Values.Clear();
            for (int i = 0; i < Mathf.Min(_keys.Count, _values.Count); i++)
            {
                _dictionaryData.Keys.Add(_keys[i]);
                _dictionaryData.Values.Add(_values[i]);
            }
            _modifyValues = false;
        }

        public void PrintDictionary()
        {
            foreach (var pair in _myDictionary)
            {
                Debug.Log("Key: " + pair.Key + "Value: " + pair.Value);
            }
        }
    }
}

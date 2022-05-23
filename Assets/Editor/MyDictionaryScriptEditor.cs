using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace HomeWork6
{
    [CustomEditor(typeof(MyDictionary))]
    public class MyDictionaryScriptEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (((MyDictionary)target)._modifyValues)
            {
                if (GUILayout.Button("Save changes"))
                {
                    ((MyDictionary)target).DeserializeDictionary();
                }
            }
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            if (GUILayout.Button("Print Dictionary"))
            {
                ((MyDictionary)target).PrintDictionary();
            }
        }
    }
}

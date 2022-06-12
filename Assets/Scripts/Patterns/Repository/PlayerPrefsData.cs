using UnityEngine;

namespace Asteroids.Repository
{
    public class PlayerPrefsData : IData<SavedData>
    {
        public void Save(SavedData data, string path = null)
        {
            PlayerPrefs.SetString("Name", data.Name);
            PlayerPrefs.SetFloat("PosX", data.PosX);
            PlayerPrefs.SetFloat("PosY", data.PosY);
            PlayerPrefs.SetFloat("PosZ", data.PosZ);
            PlayerPrefs.SetString("IsEnable", data.IsEnabled.ToString());
            //-----------------------------
            PlayerPrefs.Save();
        }
        public SavedData Load(string path = null)
        {
            var result = new SavedData();
            var key = "Name";
            if (PlayerPrefs.HasKey(key))
            {
                result.Name = PlayerPrefs.GetString(key);
            }
            key = "PosX";
            if (PlayerPrefs.HasKey(key))
            {
                result.PosX = PlayerPrefs.GetFloat(key);
            }
            key = "PosY";
            if (PlayerPrefs.HasKey(key))
            {
                result.PosY = PlayerPrefs.GetFloat(key);
            }
            key = "PosZ";
            if (PlayerPrefs.HasKey(key))
            {
                result.PosZ = PlayerPrefs.GetFloat(key);
            }
            key = "IsEnable";
            if (PlayerPrefs.HasKey(key))
            {
                var str = PlayerPrefs.GetString(key);
                result.IsEnabled = result.TryBool(str);
            }
            return result;
        }
        public void Clear()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}

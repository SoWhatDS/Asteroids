using UnityEngine;
using System.IO;

namespace HomeWork6
{
    public class FromJSONtoClass 
    {
        public Unit[] units = new Unit[3];
        public string path;
        public string fileSTR;

        public Unit[] ReadFile(string file)
        {
            path = Application.streamingAssetsPath + file;
            fileSTR = File.ReadAllText(path);
            units = JsonHelper.FromJson<Unit>(fileSTR);
            return units;
        }

        public Unit CreateMage(Unit[] units)
        {
            for (int i = 0; i < units.Length; i++)
            {
                if (units[i].type == "mag")
                {
                    return units[i];
                }
                break;
            }
            return null;
        }

        public Unit CreateInfantry(Unit[] units)
        {
            for (int i = 0; i < units.Length; i++)
            {
                if (units[i].type == "infantry")
                {
                    return units[i];
                }
                break;
            }
            return null;
        }
     
    }
}

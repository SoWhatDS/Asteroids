using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

namespace HomeWork6
{
    public class FabricMage : MonoBehaviour
    {       
        public Unit[] _units = new Unit[3];
        public string path = "/JSON.json";
        FromJSONtoClass fromJson = new FromJSONtoClass();

        public void Start()
        {                                                     
            

        }

    }

    
}

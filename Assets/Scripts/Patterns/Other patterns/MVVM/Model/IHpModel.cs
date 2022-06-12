using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVVM
{
    interface IHpModel 
    {
        float MaxHp { get;}

        float CurrentHp { get; set; }


    }
}

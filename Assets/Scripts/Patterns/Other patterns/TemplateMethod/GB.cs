using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids.Template
{
    public class GB : Site
    {
        protected override void DrawBody()
        {
            Debug.LogError("++++++++++");
        }

        protected override void DrawFooter()
        {
            Debug.LogError("==========");
        }

        protected override void DrawHeader()
        {
            Debug.LogError("----------");
        }
    }
}

using UnityEngine;

namespace Asteroids.Template
{
    public sealed class VK : Site
    {
        protected override void DrawBody()
        {
            Debug.Log("----------"); 
        }

        protected override void DrawFooter()
        {
            Debug.Log("+++++++++++");
        }

        protected override void DrawHeader()
        {
            Debug.Log("==========");
        }
    }
}

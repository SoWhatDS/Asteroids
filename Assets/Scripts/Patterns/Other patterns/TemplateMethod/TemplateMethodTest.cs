using UnityEngine;

namespace Asteroids.Template
{
    public sealed class TemplateMethodTest : MonoBehaviour
    {
        private void Start()
        {
            Site vk = new GB();
            vk.Draw();
        }
    }
}

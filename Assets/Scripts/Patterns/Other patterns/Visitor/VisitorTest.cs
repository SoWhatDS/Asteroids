
using UnityEngine;

namespace Asteroids.Visitors
{
    public sealed class VisitorTest : MonoBehaviour
    {
        public float Damage;
        private Camera _mainCamera;
        private float _dedicateDistance = 20.0f;

        private void Start()
        {
            _mainCamera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition),
                    out var hit, _dedicateDistance))
                {
                    if (hit.collider.TryGetComponent<Hit>(out var damage))
                    {
                        damage.Activate(new ConsoleDisplay(), new InfoCollision(Damage, hit.point, hit.normal, hit.collider.transform));
                        damage.Activate(new ApplyDamage(), new InfoCollision(Damage, hit.point, hit.normal, hit.collider.transform));
                    }
                }
            }
        }
    }
}

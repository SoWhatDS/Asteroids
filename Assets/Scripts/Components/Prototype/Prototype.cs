using UnityEngine;
using UnityEngine.UI;

namespace Asteroids
{
    internal sealed class Prototype : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _lifeTime;
        [SerializeField] private float _force;

        private float _hp;

        private void Start()
        {
            if (_button is { })
            {
                _button.onClick.AddListener(() =>
               {
                   var prototype = Clone();
                   Destroy(prototype.gameObject, _lifeTime);
               });
            }

        }

        public Prototype Clone()
        {
            Prototype newObject = default;
            newObject = new GameObject(name).AddComponent<Prototype>();
            if (gameObject.TryGetComponent<Rigidbody2D>(out var rigidbody2D))
            {
                var rigidBodyNew = newObject.gameObject.AddComponent<Rigidbody2D>();
                rigidBodyNew.velocity = rigidbody2D.velocity;
                rigidBodyNew.AddForce(Random.insideUnitSphere * _force);
            }
            if (gameObject.TryGetComponent<SpriteRenderer>(out var spriteRenderer))
            {
                var spriteRendererNew = newObject.gameObject.AddComponent<SpriteRenderer>();
                spriteRendererNew.sprite = spriteRenderer.sprite;
            }
            if (gameObject.TryGetComponent<BoxCollider2D>(out var boxCollider))
            {
                var boxColliderNew = newObject.gameObject.AddComponent<BoxCollider>();
                boxColliderNew.size = boxCollider.size;
            }

            newObject._hp = _hp;
            newObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            return newObject;
        }

    }
}


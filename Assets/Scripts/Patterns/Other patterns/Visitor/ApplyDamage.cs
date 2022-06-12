using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Visitors
{
    public sealed class ApplyDamage : IDealingDamage
    {
        public void Visit(Enemy hit, InfoCollision info)
        {
            hit.Health -= info.Damage;
            hit.TextMesh.text = hit.Health.ToString();
        }

        public void Visit(Environment hit, InfoCollision info)
        {
           var projectorRotation = Quaternion.FromToRotation(-Vector3.forward, info.Normal);
            var obj = Object.Instantiate(hit.Projector, info.Point + info.Normal * 0.25f, projectorRotation, info.ObjCollision);
            obj.transform.rotation = Quaternion.Euler(obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, Random.Range(0, 360));
        }

        public void Visit(Knight hit, InfoCollision info)
        {
            var armor = hit.Armor;
            var damage = info.Damage;

            if (Random.Range(0, 100) <= 85)
            {
                if (armor <= info.Damage)
                {
                    damage = 0;
                }
                else 
                {
                    damage = info.Damage - armor;
                }
            }
            hit.Health -= damage;
            hit.TextMesh.text = hit.Health.ToString();
        }

        public void Visit(Mob hit, InfoCollision info)
        {
            hit.Health -= info.Damage;
            hit.TextMesh.text = hit.Health.ToString();
        }

        public void Visit(HitImpl hit, InfoCollision info)
        {
            Object.Destroy(hit.gameObject);
        }   

        void IDealingDamage.Visit(Asteroids.Enemy hit, InfoCollision info)
        {

            hit.Health -= info.Damage;
            Text text = GameObject.FindObjectOfType<Text>();            
            text.text = hit.Health.ToString();  
            
        }
    }
}

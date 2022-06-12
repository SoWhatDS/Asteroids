using UnityEngine;

namespace Asteroids.Repository
{
    public class SavedData
    {
        public float PosX;
        public float PosY;
        public float PosZ;
        public string Name { get; internal set; }
        public Vector3 Position { get; internal set; }
        public bool IsEnabled { get; internal set; }

        public bool TryBool(string isEnable)
        {
            return bool.Parse(isEnable);
        }
    }
}

using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        [SerializeField] private GameData _gameData;
        private Controllers _controllers;    
      
        void Awake()
        {
            _controllers = new Controllers();
            new GameInitialization(_controllers, _gameData);                          
        }
       
        void Update()
        {
            _controllers.Update();
            
        }
    }
}

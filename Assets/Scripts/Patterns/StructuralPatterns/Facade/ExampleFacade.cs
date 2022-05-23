using UnityEngine;


namespace Asteroids.Facade
{
    public class ExampleFacade : MonoBehaviour
    {

        [SerializeField] private string _playerName;
        [SerializeField] private float _playerHp;
        [SerializeField] private float _enemyHp;
        [SerializeField] private int _mapSize;
        [SerializeField] private float _damageEnemy;
        [SerializeField] private Transform _positionEnemy;

        
        void Start()
        {
            var gameService = new GameService();
            gameService.Start(_mapSize,_playerName,_playerHp,_enemyHp,_damageEnemy,_positionEnemy);
        }

       
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Switch
{
    public sealed class SwitchPattern 
    {
        private readonly Dictionary<Move, Action> _moveMap;

        public SwitchPattern()
        {
            _moveMap = new Dictionary<Move, Action>
            {
                { Move.Up, MoveUp },
                { Move.Down, MoveDown },
                { Move.Left, MoveLeft },
                { Move.Right, MoveRight },
                {
                    Move.Combo, () =>
                     {
                         MoveUp();
                         MoveUp();
                         MoveDown();
                         MoveDown();
                     }
                }
            };
        }
        

        public void Perform(Move move)
        {
            switch (move)
            {
                case Move.Up:
                    MoveUp();
                    break;
                case Move.Down:
                    MoveDown();
                    break;
                case Move.Left:
                    MoveLeft();
                    break;
                case Move.Right:
                    MoveRight();
                    break;
                case Move.Combo:
                    MoveUp();
                    MoveUp();
                    MoveDown();
                    MoveDown();
                    break;
            }
        }

        public void PerformWithDictionary(Move move)
        {
            _moveMap[move].Invoke();
        }

        private void NameMethod()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                PerformWithDictionary(Move.Up);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                PerformWithDictionary(Move.Down);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                PerformWithDictionary(Move.Left);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                PerformWithDictionary(Move.Right);
            }                   
        }
        private void MoveDown() { }
        private void MoveUp() { }
        private void MoveLeft() { }
        private void MoveRight() { }
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public sealed class PlayerBall : Player
    {
        public PlayerBall(float _speed) : base(_speed) 
        {

        }

        private void FixedUpdate()
        {
            Move();
        }
    }
}
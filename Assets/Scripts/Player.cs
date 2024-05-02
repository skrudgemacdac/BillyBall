using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public abstract class Player : MonoBehaviour
    {
        [SerializeField] protected internal float Speed;
        [SerializeField] protected internal int XP = 0;
        private Rigidbody _rigidBody;

        public Player(float _speed)
        {
            Speed = _speed;
        }

        void Start() 
        {
            _rigidBody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

            _rigidBody.AddForce(movement * Speed);
        }
    }
}
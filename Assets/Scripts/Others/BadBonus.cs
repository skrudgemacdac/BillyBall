using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public class BadBonus : InteractiveObject, IFlay, IRotation, ISlowDown, IQuickDeath
    {
        private float _lengthFlay;
        private float _speedRotation;
        private PlayerController _playerController;

        private void Awake()
        {
            _lengthFlay = Random.Range(1.0f, 5.0f);
            _speedRotation = Random.Range(10.0f, 50.0f);
        }

        protected override void Interaction()
        {
            
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthFlay), transform.localPosition.z);

        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

        public void SlowDown()
        {
            _playerController.speed -= 15;
        }

        public void killPlayer()
        {
            _playerController.hp -= _playerController.hp;
        }
    }
}
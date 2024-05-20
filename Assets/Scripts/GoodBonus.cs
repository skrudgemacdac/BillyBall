using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public class GoodBonus : InteractiveObject, Interaction
    {
        [SerializeField] private Player _player;
        private float _bonusSpeed = 25f;
        private int _bonusXP = 50;

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.CompareTag("Player"))
            {
                Interact();
            }
            Destroy(gameObject, 0.2f);
        }

        protected override void Interact() 
        {
            if (gameObject.CompareTag("SpeedBonus"))
            {
                _player.Speed += _bonusSpeed;
                EventManager.OnAddSpeed();
            }
            else if (gameObject.CompareTag("XPBonus")) 
            {
                _player.XP += _bonusXP;
                EventManager.OnAddXP();
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public class GoodBonus : InteractiveObject, Interaction
    {
        [SerializeField] private Player _player;
        private float bonusSpeed = 50f;

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
                _player.Speed += bonusSpeed;
            }
            else if (gameObject.CompareTag("XPBonus")) 
            {
                _player.XP += 50;
            }
        }
    }
}
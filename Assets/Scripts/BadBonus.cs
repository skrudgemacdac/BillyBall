using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public class BadBonus : InteractiveObject
    {
        [SerializeField] private Player _player;

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.CompareTag("Player")) 
            {
                Interact();
            }
        }

        protected override void Interact()
        {
            if (_player.Speed > 25)
            {
                Destroy(gameObject, 0.2f);
                _player.Speed -= 25;
                EventManager.OnMinusSpeed();
            }
        }
    }
}
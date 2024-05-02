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
            Destroy(gameObject, 0.2f);
        }

        protected override void Interact()
        {
            _player.Speed -= 25;
        }
    }
}
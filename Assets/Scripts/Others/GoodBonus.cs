using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public class GoodBonus : InteractiveObject, IFlay, IFlicker, IInvincibility, ISpeedBonus
    {
        private Material _material;
        private float _lengthFlay;
        private PlayerController _playerController;

        private DisplayBonuses _displayBonuces;

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Random.Range(1.0f, 5.0f);
            _displayBonuces = new DisplayBonuses();
        }

        protected override void Interaction()
        {
            // Add bonus
            _displayBonuces.Display(5);
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthFlay), transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }

        public void MakeInvincible()
        {
            _playerController.IsInvicible = true;
        }

        public void AddSpeed()
        {
            _playerController.speed += 15;
        }
    }
}

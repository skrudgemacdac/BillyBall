using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace BillyBall 
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable
    {
        public bool IsInterectable { get; } = true;

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInterectable || !other.CompareTag("Player")) 
            {
                return;
            }
            Interaction();
            Destroy(gameObject);
        }

        protected abstract void Interaction();

        private void Start()
        {
            Action();
        }

        public void Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public abstract class InteractiveObject : MonoBehaviour, Interaction
    {
        protected virtual void Interact() 
        {

        }
    }
}
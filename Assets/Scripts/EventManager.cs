using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public class EventManager
    {
        public static event Action addXP;
        public static event Action addSpeed;
        public static event Action minusSpeed;

        public static void OnAddXP() 
        {
            addXP?.Invoke();
        }

        public static void OnAddSpeed() 
        {
            addSpeed?.Invoke();
        }

        public static void OnMinusSpeed() 
        {
            minusSpeed?.Invoke();
        }
    }
}
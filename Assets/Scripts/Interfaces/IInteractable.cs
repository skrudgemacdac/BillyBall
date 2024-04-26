using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BillyBall 
{
    public interface IInteractable : IAction
    {
        bool IsInterectable { get; }
    }
}
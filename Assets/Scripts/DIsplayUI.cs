using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace BillyBall 
{
    public class DIsplayUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _xp;
        private int XPChange = 0;

        [SerializeField] private TextMeshProUGUI _speed;
        private float SpeedChange = 0;

        void Start()
        {
            //Вызывает nullReferenceException
            //_xp = GetComponent<TextMeshProUGUI>();

            EventManager.addXP += OnAddXP;
            EventManager.addSpeed += OnAddSpeed;
            EventManager.minusSpeed += OnMinusSpeed;

        }

        public void OnAddXP() 
        {
            XPChange += 50;
            _xp.text = "XP: " + XPChange;

            #region
            /*
             * try
               {
                   XPChange += 50;
                  _xp.text = "XP: " + XPChange;
               }
               catch (NullReferenceException exc)
               {
                   Debug.Log("Неизвестная ошибка. Информация об ошибке: " + exc.Message);
               }
               finally 
               {

               }
            */
            #endregion
        }

        public void OnAddSpeed() 
        {
            SpeedChange += 50;
            _speed.text = "Speed: " + SpeedChange;
        }

        public void OnMinusSpeed() 
        {
            SpeedChange -= 25;
            _speed.text = "Speed: " + SpeedChange;
        }
    }
}
using System;
using UnityEngine;
using Zenject;

namespace FindMe.Player
{
    public class PLayerInputController :ITickable
    {
        public event Action OnForwardMove;
        public event Action OnBackMove;
        public event Action OnTurnLeft;
        public event Action OnTurnRight;
        public event Action OnStay;

        public void Tick()
        {
            CheckInput();
        }

        private void CheckInput()
        {
            if (Input.GetKey(KeyCode.W))
            {
                OnForwardMove?.Invoke();
            }
            if (Input.GetKey(KeyCode.S))
            {
                OnBackMove?.Invoke();
            }
            if (Input.GetKey(KeyCode.A))
            {
                OnTurnLeft?.Invoke();
            }
            if (Input.GetKey(KeyCode.D))
            {
                OnTurnRight?.Invoke();
            }
            else if (Input.anyKey == false)
            {
                OnStay?.Invoke();
            }
        }
    }
}
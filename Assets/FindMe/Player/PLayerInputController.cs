using System;
using UnityEngine;
using Zenject;

namespace FindMe.Player
{
    public class PLayerInputController :ITickable
    {
        public event Action OnForwardMove;
        public event Action OnBAckMove;

        private void CheckInput()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                OnForwardMove?.Invoke();
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                OnBAckMove?.Invoke();
            }
        }

        public void Tick()
        {
            CheckInput();
        }
    }
}
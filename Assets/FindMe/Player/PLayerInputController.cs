using System;
using UnityEngine;
using Zenject;

namespace FindMe.Player
{
    public class PLayerInputController :ITickable
    {
        private readonly TickableManager _tickableManager;
        public event Action OnForwardMove;
        public event Action OnBAckMove;

        public PLayerInputController(TickableManager tickableManager)
        {
            _tickableManager = tickableManager;
            
        }

        private void CheckInput()
        {
            if (Input.GetKey(KeyCode.W))
            {
                OnForwardMove?.Invoke();
            }
            if (Input.GetKey(KeyCode.S))
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
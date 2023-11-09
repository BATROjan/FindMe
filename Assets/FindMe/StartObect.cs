using System;
using UnityEngine;
using Zenject;

namespace FindMe
{
    public class StartObect: MonoBehaviour
    {
        [Inject] private GameController _gameController;

        private void Start()
        {
            _gameController.StartGame();
        }
    }
}
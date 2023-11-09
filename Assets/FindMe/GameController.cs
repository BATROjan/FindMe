using System;
using FindMe.Player;
using UnityEngine;
using Zenject;

namespace FindMe
{
    public class GameController
    {
        private readonly PlayerController _playerController;

        public GameController(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void StartGame()
        {
            _playerController.Spawn();
        }
    }
}
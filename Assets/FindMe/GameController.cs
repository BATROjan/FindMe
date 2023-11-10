using System;
using FindMe.Animation;
using FindMe.Player;
using UnityEngine;
using Zenject;

namespace FindMe
{
    public class GameController
    {
        private readonly PlayerController _playerController;
        private readonly AnimatorController _animatorController;

        public GameController(PlayerController playerController,
            AnimatorController animatorController)
        {
            _animatorController = animatorController;
            _playerController = playerController;
        }

        public void StartGame()
        {
            _playerController.Spawn();
        }
    }
}
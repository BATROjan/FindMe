using FindMe.Player;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Zenject;

namespace FindMe.Animation
{
    public class AnimatorController
    {
        private readonly Animator _animator;
        private readonly PlayerController _playerController;

        private PlayerView _playerView;

        public AnimatorController(
            PLayerInputController pLayerInputController,
            PlayerController playerController,
            Animator animator)
        {
            _playerController = playerController;
            _animator = animator;
        }

        public void SetRun(float value)
        {
            _animator.SetFloat("Velocity", value);
        }

        public void SetIdle()
        {
        }
    }
}
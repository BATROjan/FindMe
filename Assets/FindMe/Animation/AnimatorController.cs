using FindMe.Player;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Zenject;

namespace FindMe.Animation
{
    public class AnimatorController: ITickable
    {
        private readonly Animator _animator;
        private readonly PLayerMovementController _playerMovementController;

        private PlayerView _playerView;

        private float _playerVelocity;

        public AnimatorController(
            PLayerMovementController playerMovementController,
            Animator animator)
        {
            _playerMovementController = playerMovementController;
            _animator = animator;
        }

        public void SetRun()
        {
            
        }

        public void SetIdle()
        {
        }

        public void Tick()
        {
            Debug.Log(_playerVelocity);
            _playerVelocity = _playerMovementController.PlayerVelocity;
            _animator.SetFloat("Velocity", _playerVelocity );
        }
    }
}
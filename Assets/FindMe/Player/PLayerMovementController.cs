using FindMe.Animation;
using UnityEngine;
using Zenject;

namespace FindMe.Player
{
    public class PLayerMovementController : ITickable
    {
        public float PlayerVelocity => _playerVelocity;

        private PLayerInputController _pLayerInputController;
        private readonly PlayerController _playerController;

        private const float Speed = 0.5f;
        private readonly float _step;
        private float _playerVelocity;

        public PLayerMovementController(
            PlayerController playerController,
            PLayerInputController pLayerInputController)
        {
            _pLayerInputController = pLayerInputController;
            _playerController = playerController;

            _pLayerInputController.OnForwardMove += MoveForward;
            _pLayerInputController.OnBackMove += MoveBack; 
            _pLayerInputController.OnTurnLeft += TurnLeft;
            _pLayerInputController.OnTurnRight += TurnRight;
            _pLayerInputController.OnStay += Stay;

            _step = Speed * Time.deltaTime;
        }

        public void Tick()
        {
            _playerVelocity = _playerController.PlayerView.GetComponent<Rigidbody>().velocity.magnitude;
        }

        private void Stay()
        {
        }

        private void MoveForward()
        {
            var playerPosistion = _playerController.PlayerView.transform.position;

            var target = playerPosistion + _playerController.PlayerView.transform.TransformDirection(Vector3.back);
            _playerController.PlayerView.transform.position = Vector3.MoveTowards(playerPosistion, target, _step);
        }

        private void MoveBack()
        {
            var playerPosistion = _playerController.PlayerView.transform.position;
            var target = playerPosistion + _playerController.PlayerView.transform.TransformDirection(Vector3.forward);

            _playerController.PlayerView.transform.position = Vector3.MoveTowards(playerPosistion, target, _step);

        }

        private void TurnLeft()
        {
            _playerController.PlayerView.transform.Rotate(0,-1,0);
        }

        private void TurnRight()
        {
            _playerController.PlayerView.transform.Rotate(0,1,0);
        }
    }
}
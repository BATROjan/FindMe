using UnityEngine;
using Zenject;

namespace FindMe.Player
{
    public class PLayerMovementController
    {
        private PLayerInputController _pLayerInputController;
        private readonly PlayerController _playerController;

        private const float Speed = 1f;
        private readonly float _step;

        public PLayerMovementController(
            PlayerController playerController,
            PLayerInputController pLayerInputController)
        {
            _pLayerInputController = pLayerInputController;
            _playerController = playerController;
            
            _pLayerInputController.OnForwardMove += MoveForward;
            _pLayerInputController.OnBAckMove += MoveBack;

            _step = Speed * Time.deltaTime;
        }

        private void MoveForward()
        {
            var playerPosistion = _playerController.PlayerView.transform.position;
            var target = playerPosistion + Vector3.back;

            _playerController.PlayerView.transform.position = Vector3.MoveTowards(playerPosistion, target, _step);
            
        }

        private void MoveBack()
        {
            var playerPosistion = _playerController.PlayerView.transform.position;
            var target = playerPosistion + Vector3.forward;

            _playerController.PlayerView.transform.position = Vector3.MoveTowards(playerPosistion, target, _step);
        }
    }
}
using UnityEngine;

namespace FindMe.Player
{
    public class PLayerMovementController
    {
        private PLayerInputController _pLayerInputController;
        private readonly PlayerView _playerView;
        
        private const float Speed = 5f;

        public PLayerMovementController(
            PlayerView playerView,
            PLayerInputController pLayerInputController)
        {
            _pLayerInputController = pLayerInputController;
            _playerView = playerView;
            
            _pLayerInputController.OnForwardMove += MoveForward;
            _pLayerInputController.OnBAckMove += MoveBack;
        }

        private void MoveForward()
        {
            var playerPosistion = _playerView.transform.position;
            Vector3 newPosiion = playerPosistion + new Vector3(10, 0, 0) * Speed;

            playerPosistion = newPosiion;
        }

        private void MoveBack()
        {
            
        }
    }
}
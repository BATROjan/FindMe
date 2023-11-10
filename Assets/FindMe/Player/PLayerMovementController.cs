using FindMe.Animation;
using UnityEngine;
using Zenject;

namespace FindMe.Player
{
    public class PLayerMovementController
    {
        private PLayerInputController _pLayerInputController;
        private readonly PlayerController _playerController;
        private readonly AnimatorController _animatorController;

        private const float Speed = 0.5f;
        private readonly float _step;

        public PLayerMovementController(
            AnimatorController animatorController,
            PlayerController playerController,
            PLayerInputController pLayerInputController)
        {
            _pLayerInputController = pLayerInputController;
            _playerController = playerController;
            _animatorController = animatorController;
            
            _pLayerInputController.OnForwardMove += MoveForward;
            _pLayerInputController.OnBackMove += MoveBack; 
            _pLayerInputController.OnTurnLeft += TurnLeft;
            _pLayerInputController.OnTurnRight += TurnRight;
            _pLayerInputController.OnStay += Stay;

            _step = Speed * Time.deltaTime;
        }

        private void Stay()
        {
            _animatorController.SetRun(0);
        }

        private void MoveForward()
        {
            var playerPosistion = _playerController.PlayerView.transform.position;

            var target = playerPosistion + _playerController.PlayerView.transform.TransformDirection(Vector3.back);
            _playerController.PlayerView.transform.position = Vector3.MoveTowards(playerPosistion, target, _step);
           // _animatorController.SetRun(_pLayerInputController);
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
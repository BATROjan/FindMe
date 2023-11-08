using System;
using UnityEngine;

namespace FindMe.Player
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Config/PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] private PlayerModel[] _playerModels;
    }

    public enum State
    {
        Idle,
        Run
    }

    [Serializable]
    public struct PlayerModel
    {
        public State State;
        public AnimationClip AnimationClip;
    }
}
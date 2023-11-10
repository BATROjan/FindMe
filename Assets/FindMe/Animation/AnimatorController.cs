using UnityEngine;
using UnityEngine.PlayerLoop;
using Zenject;

namespace FindMe.Animation
{
    public class AnimatorController
    {
        private readonly Animator _animator;

        public AnimatorController(Animator animator)
        {
            _animator = animator;
        }

        public void ChaneState(string name)
        {
            _animator.Play(name);
        }
    }
}
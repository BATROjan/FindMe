using UnityEngine;
using Zenject;

namespace FindMe.Animation
{
    public class AnimatorInstaller : Installer<AnimatorInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<Animator>()
                .FromComponentInHierarchy()
                .AsSingle();
            
            Container
                .Bind<AnimatorController>()
                .AsSingle()
                .NonLazy();
        }
    }
}
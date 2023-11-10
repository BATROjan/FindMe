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
                .BindInterfacesAndSelfTo<AnimatorController>()
                .AsSingle()
                .NonLazy();
        }
    }
}
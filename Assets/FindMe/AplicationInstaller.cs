using FindMe.Player;
using UnityEngine;
using Zenject;
using AnimatorInstaller = FindMe.Animation.AnimatorInstaller;

namespace FindMe
{
    public class AplicationInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            CameraInstaller.Install(Container);

            Container
                .InstantiatePrefabResource("Plane");

            PlayerInstaller.Install(Container);
           
            AnimatorInstaller.Install(Container);

            Container
                .Bind<GameController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .InstantiatePrefabResource("Start");
        }
    }
}
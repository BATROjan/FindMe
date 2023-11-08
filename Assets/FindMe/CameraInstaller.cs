using UnityEngine;
using Zenject;

namespace FindMe
{
    public class CameraInstaller : Installer<CameraInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<CameraView>()
                .FromComponentInNewPrefabResource("Main Camera")
                .AsSingle()
                .NonLazy();
        }
    }
}
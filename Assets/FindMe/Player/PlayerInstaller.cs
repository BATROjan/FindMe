using Zenject;

namespace FindMe.Player
{
    public class PlayerInstaller : Installer<PlayerInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<PLayerInputController>().AsSingle();

            Container
                .BindMemoryPool<PlayerView, PlayerView.Pool>()
                .WithInitialSize(1)
                .FromComponentInNewPrefabResource("Player");

            Container
                .Bind<PlayerController>().AsSingle().NonLazy();

            Container
                .Bind<PLayerMovementController>().AsSingle().NonLazy();
        }
    }
}
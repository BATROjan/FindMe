using Zenject;

namespace FindMe.Player
{
    public class PlayerInstaller : Installer<PlayerInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<PLayerInputController>()
                .AsSingle()
                .NonLazy();

            Container
                .Bind<PLayerMovementController>().AsSingle().NonLazy();
            Container
                .Bind<PlayerController>();

            Container
                .BindMemoryPool<PlayerView, PlayerView.Pool>()
                .WithInitialSize(1)
                .FromComponentInNewPrefabResource("Player");
        }
    }
}
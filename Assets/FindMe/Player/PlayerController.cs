using Zenject;

namespace FindMe.Player
{
    public class PlayerController: ITickable
    {
        private readonly PlayerView.Pool _playerPool;

        public PlayerController( PlayerView.Pool playerPool)
        {
            _playerPool = playerPool;
        }

        public void Tick()
        {
            
        }

        public void Spawn()
        {
            _playerPool.Spawn();
        }
    }
}
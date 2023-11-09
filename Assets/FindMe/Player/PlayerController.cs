using Zenject;

namespace FindMe.Player
{
    public class PlayerController
    {
        public PlayerView PlayerView => _playerView;
       
        private readonly PlayerView.Pool _playerPool;
       
        private PlayerView _playerView;

        public PlayerController( PlayerView.Pool playerPool)
        {
            _playerPool = playerPool;
        }
        public void Spawn()
        {
          _playerView = _playerPool.Spawn();
        }
    }
}
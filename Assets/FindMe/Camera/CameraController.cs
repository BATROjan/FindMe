namespace FindMe.Camera
{
    public class CameraController
    {
        private CameraView _cameraView;

        public CameraController(CameraView cameraView)
        {
            _cameraView = cameraView;
        }

        public CameraView GetCameraView()
        {
            return _cameraView;
        }
    }
}
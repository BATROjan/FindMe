using UnityEngine;
using Zenject;

public class CameraView : MonoBehaviour
    {
        public Camera Camera => camera;
    
        [SerializeField] private Camera camera;

        public class Factory : PlaceholderFactory<CameraView>
        {
        }
    }
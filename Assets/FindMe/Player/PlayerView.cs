using UnityEngine;
using Zenject;

public class PlayerView : MonoBehaviour
{
    public class Pool: MonoMemoryPool<PlayerView>
    {
    
    }
}
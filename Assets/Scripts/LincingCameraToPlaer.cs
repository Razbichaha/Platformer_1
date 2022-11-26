using UnityEngine;

public class LincingCameraToPlaer : MonoBehaviour
{
    private float _positioningCameraByZ = -10;
    private Vector3 _plaer;
    private Vector3 _camera;

    [SerializeField] private PlayerMovements _player = new();

    private void Update()
    {
        _plaer = _player.transform.position;

            MoveCamera();
    }

    private void MoveCamera()
    {
        _camera = _plaer;
        _camera.z += _positioningCameraByZ;
        gameObject.transform.position = _camera;
    }
}

using UnityEngine;

public class BindCamera : MonoBehaviour
{
    [SerializeField] private PlayerMovements _player = new();

    private float _positioningCameraByZ = -10;
    private Vector3 _plaer;
    private Vector3 _camera;

    private void Update()
    {
        _plaer = _player.transform.position;

        Movement();
    }

    private void Movement()
    {
        _camera = _plaer;
        _camera.z += _positioningCameraByZ;
        gameObject.transform.position = _camera;
    }
}

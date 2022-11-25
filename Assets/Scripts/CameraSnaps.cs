
using UnityEngine;

public class CameraSnaps : MonoBehaviour
{
    [SerializeField] private Player _player = new();

    private float _deviationX = 0;
    private float _deviationY = 0;
    private float _positioningCameraByZ = -10;

    private Vector3 _vector3Plaer;
    private Vector3 _vector3Camera;

    private void Update()
    {
        _vector3Plaer = _player.transform.position;

        if (DeviationCameraCoordinatesIsBroken())
        {
            MoveCamera();
        }
    }

    private void MoveCamera()
    {
        _vector3Camera = _vector3Plaer;
        _vector3Camera.z += _positioningCameraByZ;
        gameObject.transform.position = _vector3Camera;
    }

    private bool DeviationCameraCoordinatesIsBroken()
    {
        bool isBrokenDeviation = false;
        float minimumX = _vector3Plaer.x - _deviationX;
        float minimumY = _vector3Plaer.y - _deviationY;
        float maximumX = _vector3Plaer.x + _deviationX;
        float maximumY = _vector3Plaer.y + _deviationY;

        if (gameObject.transform.position.x < minimumX | gameObject.transform.position.y < minimumY
            | gameObject.transform.position.x > maximumX | gameObject.transform.position.y > maximumY)
        {
            isBrokenDeviation = true;
        }

        return isBrokenDeviation;
    }
}

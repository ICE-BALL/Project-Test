using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _player;

    public Vector3 _delta;

    private void LateUpdate()
    {
        transform.position = _player.transform.position + _delta;
        transform.LookAt(_player.transform);
    }
}

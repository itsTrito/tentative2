using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        var position = player.transform.position;
        _transform.position = position;
        _transform.Translate(0f,0f,-10f);
    }
}
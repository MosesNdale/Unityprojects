using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void Start()
    {
        transform.position = target.position + offset;
        transform.LookAt(target.position);
    }

    private void Update()
    {
        transform.position= target.position + offset;
    }
}

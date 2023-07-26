using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float trackingSpeed;

    private Transform t;

    private void Start()
    {
        t = GetComponent<Transform>();
    }

    private void Update()
    {
        t.position = playerTransform.transform.position + playerTransform.up * offset.y + playerTransform.forward * offset.z;

        t.rotation = Quaternion.Slerp(t.rotation, playerTransform.rotation, Time.deltaTime * trackingSpeed);
    }
}
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float startSpeed;
    [SerializeField] private float lifeTime;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * startSpeed, ForceMode.Impulse);

        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
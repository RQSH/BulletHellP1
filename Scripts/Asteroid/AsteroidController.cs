using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    [SerializeField] private float minRotation;
    [SerializeField] private float maxRotation;
    [SerializeField] private float minSize;
    [SerializeField] private float maxSize;

    private Transform t;
    private Rigidbody rb;
    private float finalScale;

    private void Start()
    {
        t = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();

        float randomScale = Random.Range(minSize, maxSize);
        t.localScale = new Vector3(randomScale, randomScale, randomScale);
        finalScale = randomScale;

        rb.angularVelocity = new Vector3(RandomVelocity(), RandomVelocity(), RandomVelocity());
    }

    private float RandomVelocity()
    {
        return Random.Range(minRotation, maxRotation);
    }

    public int GetScale()
    {
        return (int)finalScale;
    }
}
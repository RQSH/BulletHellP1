using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedMultiplier;
    [SerializeField] private float turnMultiplier;

    private Transform t;
    private Rigidbody rb;
    private float x;
    private float y;
    private float throttleInput;
    private float throttleMultiplier;
    private bool destroyed = false;

    private void Start()
    {
        t = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // TURNING
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        rb.AddTorque((t.up * x + t.right * y) * turnMultiplier, ForceMode.Force);

        // THROTTLE
        throttleInput = Input.GetAxis("Throttle");

        if (throttleInput == 0)
        {
            throttleMultiplier = 1f;
        }
        else if (throttleInput < 0)
        {
            throttleMultiplier = 0;
        }
        else if (throttleInput > 0)
        {
            throttleMultiplier = 2f;
        }

        // MOVING
        rb.AddForce(t.forward * speedMultiplier * throttleMultiplier, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            destroyed = true;
            gameObject.SetActive(false);
        }
    }

    public float XInput()
    {
        return x;
    }

    public bool GetDestroyedBool()
    {
        return destroyed;
    }
}
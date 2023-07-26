using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float fireRate;

    private float nextFire;
    private Transform t;

    private void Start()
    {
        t = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetAxis("Shoot") != 0 && Time.time > nextFire)
        {
            Instantiate(bulletPrefab, t.position, t.rotation);

            nextFire = Time.time + fireRate;
        }
    }
}
using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{
    private AsteroidController asteroidController;
    private GameplayManager gm;
    private int asteroidHealth;
    private int scoreValue;

    private void Start()
    {
        asteroidController = GetComponent<AsteroidController>();
        asteroidHealth = asteroidController.GetScale();
        scoreValue = asteroidController.GetScale();

        gm = GameObject.FindWithTag("GameController").GetComponent<GameplayManager>();
    }

    private void Update()
    {
        if (asteroidHealth <= 0)
        {
            gm.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            asteroidHealth--;
        }
    }
}
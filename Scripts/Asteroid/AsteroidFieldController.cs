using UnityEngine;

public class AsteroidFieldController : MonoBehaviour
{
    [SerializeField] private GameObject asteroidPrefab;
    [SerializeField] private int asteroidAmount;
    [SerializeField] private float fieldRadius;

    private void Start()
    {
        for (int i = 0; i < asteroidAmount; i++)
        {
            Vector3 randomPosition = Random.insideUnitSphere * fieldRadius;
            Instantiate(asteroidPrefab, randomPosition, Quaternion.identity);
        }
    }
}
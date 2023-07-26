using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private float startTime;
    [SerializeField] private PlayerController pC;

    private int currentScore;
    private float currentTime;
    private bool winBool = false;
    private bool loseBool = false;

    private void Start()
    {
        currentTime = startTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        currentTime = Mathf.Clamp(currentTime, 0, startTime);

        if (currentTime <= 0)
        {
            winBool = true;
            StopTime();
        }

        if (pC.GetDestroyedBool())
        {
            loseBool = true;
            StopTime();
        }
    }

    private void StopTime()
    {
        Time.timeScale = 0;
    }

    public float GetCurrentTime()
    {
        return currentTime;
    }

    public bool GetWinBool()
    {
        return winBool;
    }

    public bool GetLoseBool()
    {
        return loseBool;
    }

    public void AddScore(int score)
    {
        currentScore += score;
    }

    public int GetScore()
    {
        return currentScore;
    }
}
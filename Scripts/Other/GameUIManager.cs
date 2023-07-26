using UnityEngine;
using TMPro;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] private GameplayManager gM;
    [SerializeField] private TMP_Text textTime;
    [SerializeField] private TMP_Text textScore;
    [SerializeField] private TMP_Text textScoreWin;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;

    private void Update()
    {
        int t = (int)gM.GetCurrentTime();
        textTime.text = "Time Remaining: " + t;

        textScore.text = "Score: " + gM.GetScore();

        if (gM.GetWinBool())
        {
            winScreen.SetActive(true);
        }

        if (gM.GetLoseBool())
        {
            loseScreen.SetActive(true);
        }
    }
}
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] LogicCheck logicCheck;
    [SerializeField] TextMeshProUGUI txtScore;

    [SerializeField] GameObject loose;
    [SerializeField] TextMeshProUGUI LooseScore;
    [SerializeField] TextMeshProUGUI TopScore;

    void Start()
    {
        scoreIncraise();
        logicCheck.PassObstacle += scoreIncraise;
        logicCheck.Loose += Loose;
    }

    public void scoreIncraise()
    {
        txtScore.text = logicCheck.Score.ToString();
    }
    public void Loose()
    {
        loose.gameObject.SetActive(true);
        LooseScore.text = "Score:" + logicCheck.Score.ToString();
        TopScore.text = "TopScore:" + PlayerPrefs.GetInt("TopScore").ToString();
    }
   
}

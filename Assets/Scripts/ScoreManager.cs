using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highScoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("HIGHSCORE: ", 0);
        scoreText.text = score.ToString() + " POINTS";
        highScoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
        if (highscore < score)
            PlayerPrefs.SetInt("HIGHSCORE: ", score);
    }

    public void ResetScore()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("HIGHSCORE: ", 0);
        scoreText.text = score.ToString() + " POINTS";
        highScoreText.text = "HIGHSCORE: " + highscore.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScore : MonoBehaviour
{
    public Text yourscore;
    public Text HighScore;
    public HighScore score;

    // Start is called before the first frame update
    void Start()
    {
        
        yourscore.text = "yourScore:" + score.currentScore.ToString();
        HighScore.text = "All Time HighScore:" + score.highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

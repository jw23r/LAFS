using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMangment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void MainMenue()
    {
         SceneManager.LoadScene("MainMenue");

    }
    public void HighScore()
    {
        SceneManager.LoadScene("EndOfGame");

    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("InStrunctions");

    }
    public void Play()
    {
        SceneManager.LoadScene("GamePlay");

    }
}

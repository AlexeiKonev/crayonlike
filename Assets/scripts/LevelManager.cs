using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static int score;
    public Text scoreText;
  public  void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
    private void Start()
    {
        scoreText = GameObject.Find("score").GetComponent<Text>();
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}

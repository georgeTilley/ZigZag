using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    public static UiManager instance;
    public GameObject zigzagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;

    public TextMeshProUGUI score;
    public TextMeshProUGUI highscore1;
    public TextMeshProUGUI highscore2;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore1.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        tapText.SetActive(false);
        zigzagPanel.GetComponent<Animator>().Play("panelup");  

    }

    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highscore2.text = PlayerPrefs.GetInt("highScore").ToString();

        gameOverPanel.SetActive(true);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

}

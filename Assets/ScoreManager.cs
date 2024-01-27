using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text loserScoreText, winnerScoreText;
    int score = 0, currentChild, finalChild;
    public GameObject EnemyGroup;
    public GameObject WinnerPanel;
    // Start is called before the first frame update
    void Start()
    {
        currentChild = EnemyGroup.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        finalChild = EnemyGroup.transform.childCount;
        score = (currentChild - finalChild) * 100;
        loserScoreText.text = "Your score: " + score;
        winnerScoreText.text = "Your score: " + score;

        if (EnemyGroup.transform.childCount == 0) 
        {
            WinnerPanel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.R)) 
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}

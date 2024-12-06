using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverDisplay;
    public bool isGameRunning = true;
    public CinemachineVirtualCamera vc;
    public Button restartButton;
    public TextMeshProUGUI winDisplay;
    public Button playAgainButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameOver()
    {
        isGameRunning = false;
        vc.enabled = false;
        gameOverDisplay.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        vc.enabled = true;
    }

    public void WinnersLoveWinning()
    {
        isGameRunning = false;
        winDisplay.gameObject.SetActive(true);
        playAgainButton.gameObject.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        vc.enabled = true;
    }
    

}

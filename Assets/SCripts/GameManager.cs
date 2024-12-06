using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverDisplay;
    public bool isGameRunning = true;
    public CinemachineVirtualCamera vc;

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
    }
}

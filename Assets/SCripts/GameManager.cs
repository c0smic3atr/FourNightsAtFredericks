using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverDisplay;
    public bool isGameRunning = true;

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
        gameOverDisplay.gameObject.SetActive(true);
    }
}

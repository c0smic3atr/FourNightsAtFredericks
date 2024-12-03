using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public int startTime;
    public int time;
    public bool isRunning;
    public TextMeshProUGUI clockDisplay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Countdown
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(1);

        if (isRunning)
        {
            time--;
            UpdateDisplay();

            if(time <= 0)
            {
                TimerDone();
            }
        }

        StartCoroutine(CountDown());
    }

    //tell when done
    public void TimerDone()
    {
        isRunning = false;
        Debug.Log("Timer done!!!!!!!!! STOP PLAYING ^_^");
    }

    //update display
    public void UpdateDisplay()
    {
        clockDisplay.text = time.ToString();
    }

    public void ChangeTime(int TimeToAdd)
    {
        time += TimeToAdd;
    }
    
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] private int maxTime = 120;
    private int currentTime = 0;
    private int Minutes => Mathf.FloorToInt(currentTime / 60);
    private int Seconds => Mathf.FloorToInt(currentTime % 60);

    public event Action Finish;

    public TMP_Text text_Timer;


    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(ClockUpdate());
    }

     private IEnumerator ClockUpdate()
    {
        currentTime = maxTime;
        while (currentTime > 0)
        {

            yield return new WaitForSeconds(1);

                currentTime--;
                SetTimerText(currentTime);
            
        }

        Finish?.Invoke();

    }

    private void SetTimerText(int currentTime)
    {
        string timeFormated = string.Format("{0:0}:{1:00}", Minutes, Seconds);
        text_Timer.SetText(timeFormated);
    }
}

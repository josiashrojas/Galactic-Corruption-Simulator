using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Scr_Market : MonoBehaviour
{
    public float targetTime = 180.0f;
    public GameObject Panel;
    public Text timer;

    void Update()
    {
        float minutes = Mathf.FloorToInt(targetTime / 60); 
        float seconds = Mathf.FloorToInt(targetTime % 60);

        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        Panel.SetActive(false);
        targetTime = 180.0f;

    }


}
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

    public static string mercado;

    void Update()
    {
        mercado = "abierto";
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
        mercado = "cerrado";
        targetTime = 180.0f;
        SceneChanger.ChangeScene("1");

    }


}
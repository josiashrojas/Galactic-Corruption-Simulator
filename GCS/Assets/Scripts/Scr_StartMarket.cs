using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_StartMarket : MonoBehaviour
{
    public GameObject Panel;

    public void Start()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }

    }
}


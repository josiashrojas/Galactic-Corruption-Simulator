using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_menugame : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject Panel3;

    public void OpenPanel()
    {
        if (Panel2 != null)
        {
            if (Panel2.activeSelf == true)
            {
                Panel2.SetActive(false);
            }
        }

        if (Panel != null)
        {
            if (Scr_Market.mercado == "abierto" && Panel3 != null)
            {
                bool isActive = Panel3.activeSelf;
                Panel3.SetActive(!isActive);
            }
            else
            {
                bool isActive = Panel.activeSelf;
                Panel.SetActive(!isActive);
            }
        }

    }
}

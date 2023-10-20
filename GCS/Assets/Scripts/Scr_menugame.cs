using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_menugame : MonoBehaviour
{
    public GameObject Panel;

    public GameObject Panel2;

    public void OpenPanel()
    {
        if (Panel2 != null){
            if (Panel2.activeSelf == true){
                Panel2.SetActive(false);
            }
        }

        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBehaviour : MonoBehaviour
{
    public void setActive(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void notActive(GameObject obj)
    {
        obj.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransferData : MonoBehaviour
{
    public int Dinero;
    public Text money;
    //  Update is called once per frame
    void Update()
    {
        Dinero = Player.player.Dinero;
        money.text = Dinero.ToString("");
    }
}

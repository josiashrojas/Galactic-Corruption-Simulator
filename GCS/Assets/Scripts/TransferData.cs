using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransferData : MonoBehaviour
{
    public int Dinero;

    public string Mision;
    public Text Money;
    //  Update is called once per frame

    void Start()
    {
        Mision = Player.player.Mission;
        Dinero = Player.player.Dinero;
    }
    void Update()
    {
        Money.text = Dinero.ToString("");
    }
}

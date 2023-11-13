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
    }
    void Update()
    {
        Dinero = Player.Dinero;
        Money.text = Dinero.ToString("");
    }
}

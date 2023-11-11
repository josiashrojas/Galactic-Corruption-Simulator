using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransferData : MonoBehaviour
{
    public int Meteoro;
    public int Dinero;
    public string Mision;
    public Text Money;
    public Text Meteor;
    //  Update is called once per frame

    void Start()
    {
        Mision = Player.player.Mission;
    }
    void Update()
    {
        Meteoro = Player.Meteoros;
        Meteor.text = Meteoro.ToString("");
        Dinero = Player.Dinero;
        Money.text = Dinero.ToString("");
    }
}

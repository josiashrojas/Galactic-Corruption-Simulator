using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int Dinero;
    public Text PlayerMoney;

    // Start is called before the first frame update
    void Start()
    {
        Dinero = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoney.text = Dinero.ToString("");
    }
}

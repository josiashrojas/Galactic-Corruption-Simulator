using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int Dinero;
    public int Acero;
    public int Combustible;

    public Text PlayerMoney;
    public Text PlayerAcero;
    public Text PlayerCombustible;

    // Start is called before the first frame update
    void Start()
    {
        Dinero = 5000;
        Acero = 0;
        Combustible = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoney.text = Dinero.ToString("");
        PlayerAcero.text = Acero.ToString("");
        PlayerCombustible.text = Combustible.ToString("");
    }
}

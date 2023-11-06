using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_Prices : MonoBehaviour
{
    public static int Meteor_Price;

    public Text Meteor_text;
    // Start is called before the first frame update
    void Start()
    {
        Meteor_Price = 500;
    }

    // Update is called once per frame
    void Update()
    {
        Meteor_text.text = "$" + Meteor_Price.ToString("");
    }

    public static void PriceVariation(string thing, string tipo)
    {
        int rnd = UnityEngine.Random.Range(0, 101);
        if (thing == "meteoro")
        {
            if (tipo == "buy")
            {
                if (rnd >= 0 && rnd <= 25)
                {
                    int rndprice = UnityEngine.Random.Range(1, 100);
                    Meteor_Price += rndprice;
                }
            }
            else if (tipo == "sell")
            {
                if (rnd >= 0 && rnd <= 25)
                {
                    int rndprice = UnityEngine.Random.Range(1, 100);
                    Meteor_Price -= rndprice;
                }
            }
        }
    }


}

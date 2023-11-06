using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scr_Shop : MonoBehaviour
{
    // Buy something
    public static void Buy(string thing)
    {
        if (thing == "meteoro")
        {
            Player.VariableVariation("meteoro", 1);
            Player.VariableVariation("dinero", -Scr_Prices.Meteor_Price);
            Scr_Prices.PriceVariation(thing, "buy");
        }
    }

    // Sell something
    public static void Sell(string thing)
    {
        if (thing == "meteoro")
        {
            Player.VariableVariation("meteoro", -1);
            Player.VariableVariation("dinero", Scr_Prices.Meteor_Price);
            Scr_Prices.PriceVariation(thing, "sell");
        }
    }
}

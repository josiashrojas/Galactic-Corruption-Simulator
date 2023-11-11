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
            if (Player.Dinero < Scr_Prices.Meteor_Price)
            {
                return;
            }
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
            if (Player.Meteoros < 1)
            {
                return;
            }
            Player.VariableVariation("meteoro", -1);
            Player.VariableVariation("dinero", Scr_Prices.Meteor_Price);
            Scr_Prices.PriceVariation(thing, "sell");
        }
    }
}

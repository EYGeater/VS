using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurrencyUI : MonoBehaviour
{
    public int totalCurrency;
    public AudioManager am;

    public void addCurrency(int currency)
    {
        //am.Play("Pickup");

        totalCurrency = totalCurrency + currency;
    }
    public void subtractCurrency(int currency)
    {
        totalCurrency = totalCurrency - currency;
    }

    //over here we do a UI display with the uhhh uhhhhh uhuh? .. the currency. 

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



[CreateAssetMenu]


public class IntData : ScriptableObject
{
    public int health = 150;
    public Text healthText;
    public boolean takeDamage;
    public boolean abilityCast = false;
    

    //theoretical attempt to damage an object's health value and display damage taken//
    void update()
    {
        if(abilityCast == true && takeDamage == true)
        {
            public int health - 100;
        }
    }


    public void DisplayDamageNumber(Text txt)
    {

    txt.text = Value.ToString("took " + txt + " damage!");

    }
}

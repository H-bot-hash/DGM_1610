using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;



//A simple practice attempt at scripting an ability that increases critical rate upon use//

public class FloatData : ScriptableObject
{
    public float attack;
    public float manaCost;
    public float defense;
    public float criticalRate = 1.0f;
    public Text stats;

    public boolean ability;


    public new string characterName;


    public void Print()
    {
        debug.log(characterName + ":" + "Has a critical rate of" + criticalRate);

    }
    
    //when the ability is used increase the critical rate by 1//
    public void CharacterMana (float number)
    {
        manaCost = 150
            ability = true;
    }

    public void UpdateCritical(float number)
    {
        if(ability == true)
        {
            criticalRate++;
        }
    }
    
}

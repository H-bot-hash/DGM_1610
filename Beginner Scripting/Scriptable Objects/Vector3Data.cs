using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//A theoretical exercise to move a cart in corespondence with a simlar object that references cartPos from this class.//

public class Vector3Data : ScriptableObject
{

    public Vector3Data cartPos;

    public void MoveCart(Vector3Data 4)
    {
        cart += 4;
        PrintMovement();
    }

    public void ReplaceCart(Vector3Data 0)
    {
        cart = 0;
        PrintReset();
    }

    //Print if the cart moved.//

    public void PrintMovement(Vector3Data)
    {
        debug.log("the cart has moved" + Vector3Data + "feet");
    }

    //print if the cart was reset
    public void PrintReset(Vector3Data)
    {
        debug.log("the cart has been reset from " + Vector3Data);
    }

}

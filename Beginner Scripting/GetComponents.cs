using UnityEngine;
using System.Collections;

//Get component is processor heavy, call it only when needed or in the awake or state stages

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;
    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    
    void Awake ()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    
    void Start ()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
//would be created as their own scripts
using UnityEngine;
using System.Collections;

public class AnotherScript : MonoBehaviour
{
    public int playerScore = 9001;
}


//would be created as their own scripts
using UnityEngine;
using System.Collections;

public class YetAnotherScript : MonoBehaviour
{
    public int numberOfPlayerDeaths = 3;
}
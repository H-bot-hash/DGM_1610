//Active Objects//

using UnityEngine;
using System.Collections;
using UnityEngine.Events;


//A theoretical script that will only allow the player to continue the objective if they have aquired a fire-resistance potion//

public class ActiveObjects : MonoBehaviour
{
    public UnityEvent activateObject;
    public void heathPoints;

    public bool isStandingonfire;
    public bool isFireResistant;

    
    void Start ()
    {
        gameObject.SetActive(false);
    }

    void OnStartTrigger()
    {
        ActivateObject.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isFireResistant == false)
            heathPoints -= 50;

        if (isFireResistant == true)
            OnStartTrigger();
    }
    
}


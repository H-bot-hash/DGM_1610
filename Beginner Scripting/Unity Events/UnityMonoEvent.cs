//Active Objects//

using UnityEngine;
using System.Collections;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent awakeHP, resetMP, OnCrystalTouch;
    public gameObject trigger;


    //an attempt to callback another script when fire is touched and to carry out various events on trigger enter//



    private void Awake()
    {
        awakeHP.Invoke();
    }

    

    private void OnCrystalTouch()
    {
        if (isFireResistant == true )
            public UnityEvent UnityEventBehavior.OnTriggerEnter(Collider other);

    }


    private void resetMP()
    {
        resetMP.Invoke();
    }
}
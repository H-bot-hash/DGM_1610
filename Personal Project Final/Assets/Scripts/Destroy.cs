using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    float destroyAfter = 2f;
    float Timer = 0;



    void Update()
    {
        Timer += Time.deltaTime;
        if(destroyAfter <= Timer)
        {
            Destroy(gameObject);
        }
    }
}

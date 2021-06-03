using UnityEngine;
using System.Collections;

public class AwakeAndStart : MonoBehaviour
{
    void Awake ()
    {
        Debug.Log("Has been awoken....");
    }
    
    
    void Start ()
    {
        Debug.Log("Start your engines.");
    }
}
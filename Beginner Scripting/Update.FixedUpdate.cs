using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate ()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    
    private void LateUpdate()
    {

    }

    private void OnMouseUpAsButton()
    {

    }

    void Update ()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
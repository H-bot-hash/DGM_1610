using UnityEngine;
using System.Collections;
//Acts as a look at object function, useful for cameras
public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}
using UnityEngine;
using System.Collections;
public class MouseClick : MonoBehaviour
{
    private rigidbody rb;

    private void Awake()
    {
        rb - GetComponent<Rigidbody>();
    }
    
    void OnMouseDown ()
    {
        rigidbody.AddForce(-transform.forward * 500f);
        rigidbody.useGravity = true;
    }
}
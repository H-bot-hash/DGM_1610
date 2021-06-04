using UnityEngine;
using System.Collections;
public class DualAxisExample : MonoBehaviour 
{
    public float range;
    public GUIText textOutput;

    void Update () 
    {
        float h = Input.GetAxis("Horizontal axis");
        float v = Input.GetAxis("Vertical axis");
        float xPos = h * range;
        float yPos = v * range;
        transform.position = new Vector3(xPos, yPos, 0);
        textOutput.text = "Horizontal Value is Returned: "+h.ToString("F2")+"\nVertical Value Returned to: "+v.ToString("F2");    
    }
}
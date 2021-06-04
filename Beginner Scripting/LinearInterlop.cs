using UnityEngine;
using System.Collections;

float result = Mathf.Lerp (3f, 5f, 0.5f);

//Other examples of Lerp functions include Color.Lerp and Vector3.Lerp. 
//These work in exactly the same way as Mathf.Lerp but the ‘from’ and ‘to’ values are of type Color and Vector3 respectively.

Vector3 from = new Vector3 (1f, 2f, 3f);
Vector3 to = new Vector3 (5f, 6f, 7f);
Vector3 result = Vector3.Lerp (from, to, 0.75f);

void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
}

void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
}
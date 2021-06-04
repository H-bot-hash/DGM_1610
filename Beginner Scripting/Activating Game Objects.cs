//Active Objects//

using UnityEngine;
using System.Collections;

public class ActiveObjects : MonoBehaviour
{
    void Start ()
    {
        gameObject.SetActive(false);
    }
}

//Check State

using UnityEngine;
using System.Collections;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;
    
    void Start ()
    {
        Debug.Log("Active Self object: " + myObject.activeSelf);
        Debug.Log("Active object in Hierarchy" + myObject.activeInHierarchy);
    }
}
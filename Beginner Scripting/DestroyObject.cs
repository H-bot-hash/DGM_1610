using UnityEngine;
using System.Collections;

public class DestroyBasic : MonoBehaviour
{
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
            Debug.Log(gameObject + "has been deleted");
        }
    }
}

using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour
{
    public GameObject other;
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
            Debug.Log(gameObject + "has been deleted");
        }
    }
}

using UnityEngine;
using System.Collections;

public class DestroyComponent : MonoBehaviour
{
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
            Debug.Log(gameObject + "has been deleted");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 18.0f;
    public float leftBoundary = -45.0f;
    public float rightBoundary = 45.0f;
    public GameObject projectilePrefab;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keeps the player in screen bounds
        if (transform.position.x < leftBoundary)
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
    }
}

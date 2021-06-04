using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{
    int[] myIntArray = new int [10];
    void Start()
    {
        myIntArray[0] =14;
    }
    
    int[] myIntArrays = {13, 57, 13, 990};

    
    
    public GameObject[] players;

    void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        
        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number "+i+" is named "+players[i].name);
        }
    }
}
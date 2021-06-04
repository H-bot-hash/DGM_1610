using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour 
{
    public int intelligence = 5;
    
    
    void Greet()
    {
        switch (intelligence)
        {
        case 5:
            print ("Why hello there good sir! Let me show you my wares!");
            break;
        case 4:
            print ("Hello and good day!");
            break;
        case 3:
            print ("Whadya want?");
            break;
        case 2:
            print ("LETS GOOOO!!!");
            break;
        case 1:
            print ("BleepmyBloop");
            break;
        default:
            print ("Incorrect intelligence level.");
            break;
        }
    }
}

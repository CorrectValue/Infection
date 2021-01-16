using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentColorUpdate : MonoBehaviour
{
    //This script is needed to update an agent's color when he becomes infected or dead or cured
    //wealthy - white color
    //infected - red
    //dead - black
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor(int value)
    {
        //0 - wealthy
        //1 - infected
        //-1 - dead
        switch(value)
        {
            case 0:
                //wealthy

                break;
            case 1:
                //infected

                break;
            case -1:
                //dead

                break;
            default:
                break;
        }
    }
}

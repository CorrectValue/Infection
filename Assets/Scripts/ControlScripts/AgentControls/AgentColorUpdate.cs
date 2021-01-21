using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentColorUpdate : MonoBehaviour
{
    //This script is needed to update an agent's color when he becomes infected or dead or cured
    //wealthy - white color
    //infected - red
    //dead - black
    //immune - cyan

    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        //get renderer component
        renderer = gameObject.GetComponent<Renderer>();
        //set default color - 
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
        //2 - immune
        switch(value)
        {
            case 0:
                //wealthy
                renderer.material.SetColor("_Color", Color.white);
                break;
            case 1:
                //infected
                renderer.material.SetColor("_Color", Color.red);
                break;
            case -1:
                //dead
                renderer.material.SetColor("_Color", Color.black);
                break;
            case 2:
                //immune
                renderer.material.SetColor("_Color", Color.cyan);
                break;
            default:
                break;
        }
    }
}

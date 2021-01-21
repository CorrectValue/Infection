using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMovementController : MonoBehaviour
{
    //This script handles basic agent movement
    public GameObject attractor;    //an attractor can be found by agent
    bool dead;                      //store this here for simplicity
    // Start is called before the first frame update
    void Start()
    {
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        //animate basic activity such as randomly walking around the arena
        if(!dead)
        {
            //only if an agent is alive

        }
    }

    void setDead()
    {
        //sets an agent dead
        dead = true;
    }
}

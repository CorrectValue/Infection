using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentStateController : MonoBehaviour
{
    //This script controls agent's state and its features

    private bool infected;  //if an agent is infected or not
    private bool dead;      //well..

    //other script references
    private AgentMovementController script;

    // Start is called before the first frame update
    void Start()
    {
        infected = false;
        dead = false;

        //get scripts references
        script = GetComponent<AgentMovementController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getInfected()
    {
        return infected;
    }

    public void setInfected(bool value)
    {
        infected = value;
    }
}

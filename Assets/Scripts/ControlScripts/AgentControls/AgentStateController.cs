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
    private AgentColorUpdate scr;

    private int id; //unique identifier for every agent

    // Start is called before the first frame update
    void Start()
    {
        infected = false;
        dead = false;

        //get scripts references
        script = GetComponent<AgentMovementController>();
        scr = GetComponent<AgentColorUpdate>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetInfected()
    {
        return infected;
    }

    public void SetInfected(bool value)
    {
        infected = value;
        //set new color
        scr.changeColor(1);
    }

    void die()
    {
        dead = true;
        //set new color
        scr.changeColor(-1);
    }

    public void SetId(int givenId)
    {
        //sets agent's id
        id = givenId;
    }

    public int GetId()
    {
        return id;
    }
}

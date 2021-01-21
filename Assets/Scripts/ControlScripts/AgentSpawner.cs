using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSpawner : MonoBehaviour
{
    //This script handles agents initial spawn in the arena
    public GameObject prefab; //prefab to instantiate
    public int populationCount = 20; //being set externally

    private int globalId = 0;
    private Quaternion rot; //rotation to spawn
    private GameObject agents; //parent agents object

    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.Find("Agents");
        //spawn a needed number of agents
        for (int i = 0; i < populationCount; i++)
        {
            //spawn agent of the 1st population
            var obj = Instantiate(prefab, GeneratePosition(), rot);
            
            //set id
            obj.GetComponent<AgentStateController>().SetId(globalId);
            
            //set tag
            obj.gameObject.tag = "agent";
            
            //place agents of the 1st population into a parent object
            obj.transform.parent = agents.transform;
            
            //increase globalid
            globalId++;
        }
    }

    Vector3 GeneratePosition()
    {
        //generates a position for an agent to spawn into
        float x = Random.Range(-240, 240);
        float y = 7;
        float z = Random.Range(-240, 240);

        return new Vector3(x, y, z);
    }

    public void Set()
    {
        //allows setting initial values on start
    }
}

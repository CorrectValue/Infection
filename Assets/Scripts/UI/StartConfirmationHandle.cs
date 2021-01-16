using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartConfirmationHandle : MonoBehaviour
{
    //This button handles start confirmation button
    GameObject storeObject; //store object reference
    void Start()
    {
        //get store object reference
        storeObject = GameObject.Find("StoreObject");
    }

    public void handle()
    {
        //acts when the button is pressed
        //gather all data 
        gatherData();
        //switch scene
        nextScene();

    }

    private void nextScene()
    {
        //loads next scene
        SceneManager.LoadScene("Scenes/Scene");
    }

    private void gatherData()
    {
        //receives all data from widgets and stores it in the store object
        storeObject.GetComponent<StoreObjectScript>().Set(true); //FOR NOW
    }
}

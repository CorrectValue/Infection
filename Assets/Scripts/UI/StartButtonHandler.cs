using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonHandler : MonoBehaviour
{
    //This script acts when the start button is pressed
    private GameObject ConfPanel;
    // Start is called before the first frame update
    void Start()
    {
        //get reference to confirmation panel
        ConfPanel = GameObject.Find("StartConfPanel");
        //set it inactive
        ConfPanel.gameObject.SetActive(false);
    }

    public void handle()
    {
        //acts when the button is pressed
        //show start confirmation panel
        ConfPanel.gameObject.SetActive(true);
    }
}

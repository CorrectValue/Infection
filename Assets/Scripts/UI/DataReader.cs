using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataReader : MonoBehaviour
{
    //This script reads data from the previous scene that was passes using store object
    private GameObject storeObject;
    void OnEnable()
    {
        //get store object reference
        storeObject = GameObject.Find("StoreObject");
        //read data from store object

    }
}

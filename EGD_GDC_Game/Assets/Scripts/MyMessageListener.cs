using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMessageListener : MonoBehaviour {

    private bool Connected;

    public GameObject L;
    public GameObject R;
	// Use this for initialization
	void Start () {
        Connected = false;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //called when Arduion sends a line of data

    void OnMessageArrived(string m)
    {
        //TestCommands(m);
        Debug.Log("Arrived: " + m);

    }
    void OnConnectionEvent(bool s)
    {
        Connected = s;
        Debug.Log(s ? "Device Connected" : "Device Disconnected");
    }

    public bool GetConnection()
    {
        return Connected;
    }

    void TestCommands(string CList)
    {
        string[] SS = CList.Split(new string[] { "," }, StringSplitOptions.None);
        Debug.Log(SS);
        if (SS[0] == "H")
        {
            L.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            L.GetComponent<Renderer>().material.color = Color.white;
        }
        if(SS[1] == "H")
        {
            R.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            R.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}

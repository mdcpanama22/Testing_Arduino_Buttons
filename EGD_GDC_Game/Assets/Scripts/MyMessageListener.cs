using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyMessageListener : MonoBehaviour {

    private bool Connected;

    public GameObject L;
    public GameObject R;
	public GameObject T;
	public Text CodeT;
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
        TestCommands(m);
        //Debug.Log("Arrived: " + m);

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

    bool ContainsCommand(string c, char Command){
        foreach(char x in c){
            if(x == Command){
                return true;
            }
        }
        return false;
    }


    void TestCommands(string CList)
    {
        string[] SS = CList.Split(new string[] { ","}, StringSplitOptions.None);
        String commands = "";
        foreach(String x in SS){
            commands += x;
        }
        Debug.Log(commands);
         
        if (commands.Contains("L"))
        {
            L.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            L.GetComponent<Renderer>().material.color = Color.white;
        }
        if(commands.Contains("R"))
        {
            R.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            R.GetComponent<Renderer>().material.color = Color.white;
        }
		
		//NUMPAD STUFF you have to use Keycode.Keypad# example Keycode.Keypad7 
		//or you can use Input.GetKeyDown("[7]") specifically for the keypad
		

		//I HAVE NO IDEA HOW TO MAKE THIS BETTER SO BARE WITH ME
		if(Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Insert)){
			CodeT.text += "0";
		}
		if(Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.End)){
			CodeT.text += "1";
		}
		if(Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.DownArrow)){
			CodeT.text += "2";
		}
		if(Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.PageDown)){
			CodeT.text += "3";
		}
		if(Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.LeftArrow)){
			CodeT.text += "4";
		}
		//Keypad 5 is weird, doesn't have an alternative unless it's blank
		if(Input.GetKeyDown(KeyCode.Keypad5)){
			CodeT.text += "5";
		}
		if(Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.RightArrow)){
			CodeT.text += "6";
		}
		if(Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Home)){
			CodeT.text += "7";
		}
		if(Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.UpArrow)){
			CodeT.text += "8";
		}
		if(Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.PageUp)){
			CodeT.text += "9";
		}
		if(CodeT.text.Length == 7){
			if(CodeT.text == "1234567"){
				T.GetComponent<Renderer>().material.color = Color.yellow;
			}else if(CodeT.text == "7654321"){
				T.GetComponent<Renderer>().material.color = Color.white;
			}
			CodeT.text = "";
		}
    }
}

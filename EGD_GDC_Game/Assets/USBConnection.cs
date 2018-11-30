using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
public class USBConnection : MonoBehaviour {

	public Text text_;
	private String USB1 = "D:\\";
	private String USB2 = "E:\\";
	private String USB3 = "F:\\";

	private bool USB_D_CONNECTED = false;
	private bool USB_E_CONNECTED = false;
	private bool USB_F_CONNECTED = false;

	private String TextFileName = "TestingUSB.txt";
	/*
		The Driver letter assignment in windows works as such:

		When you connect a usb it will automatically connect it to D:\ and E:\ with every subsequent one
		being the next letter.

		For this project we will be dealing with three usbs therefore:
		D:\, E:\, and F:\
	
	 */

	 /*
		We could make it so that the order of connecting USBs matter, which would override the port issue


	 */



    void Start()
    {
        string[] allDrives = Directory.GetLogicalDrives();

        foreach (string  d in allDrives)
        {
            	Debug.Log(d);
        }

		/*string path = @"c:\Users\carlsm4\Test.txt";
		// Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
				if("Testing to see if we can open this in unity;" == s){
					GetComponent<Renderer>().material.color = Color.yellow;
				}
                text_.text = s;
            }
        }*/
		
	}
	void DoSomething(){
			if(USB_D_CONNECTED || USB_E_CONNECTED || USB_F_CONNECTED){
				GetComponent<Renderer>().material.color = Color.yellow;
			}else{
				GetComponent<Renderer>().material.color = Color.white;
			}
	}

	void Update(){
		string[] allDrives = Directory.GetLogicalDrives();
		string Drives = "";
        foreach (string  d in allDrives)
        {
            Drives += d;
        }
		if(Drives.Contains(USB1)){
			USB_D_CONNECTED = true;
			//This is to test out to see if we can access the specific txt file
			/*string path = PathStart+"\\"+TextFileName;
			using (StreamReader sr = File.OpenText(path))
        	{
            	string s;
				while ((s = sr.ReadLine()) != null)
				{
					Debug.Log(s);
				}
			}*/
		}else{
			USB_D_CONNECTED = false;
		}
		if(Drives.Contains(USB2)){
			USB_E_CONNECTED = true;
			//This is to test out to see if we can access the specific txt file
			/*string path = PathStart+"\\"+TextFileName;
			using (StreamReader sr = File.OpenText(path))
        	{
            	string s;
				while ((s = sr.ReadLine()) != null)
				{
					Debug.Log(s);
				}
			}*/
		}else{
			USB_E_CONNECTED = false;
		}
		if(Drives.Contains(USB3)){
			USB_F_CONNECTED = true;
			//This is to test out to see if we can access the specific txt file
			/*string path = PathStart+"\\"+TextFileName;
			using (StreamReader sr = File.OpenText(path))
        	{
            	string s;
				while ((s = sr.ReadLine()) != null)
				{
					Debug.Log(s);
				}
			}*/
		}else{
			USB_F_CONNECTED = false;
		}


		DoSomething();
	}
}
/* 
This code produces output similar to the following:

Drive A:\
  Drive type: Removable
Drive C:\
  Drive type: Fixed
  Volume label: 
  File system: FAT32
  Available space to current user:     4770430976 bytes
  Total available space:               4770430976 bytes
  Total size of drive:                10731683840 bytes 
Drive D:\
  Drive type: Fixed
  Volume label: 
  File system: NTFS
  Available space to current user:    15114977280 bytes
  Total available space:              15114977280 bytes
  Total size of drive:                25958948864 bytes 
Drive E:\
  Drive type: CDRom

The actual output of this code will vary based on machine and the permissions
granted to the user executing it.
*/
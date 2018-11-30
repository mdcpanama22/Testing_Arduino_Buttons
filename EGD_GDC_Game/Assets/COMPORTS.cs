/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Management; 
internal class ProcessConnection { 
   public static ConnectionOptions ProcessConnectionOptions()
   {
     ConnectionOptions options = new ConnectionOptions();
     options.Impersonation = ImpersonationLevel.Impersonate;
     options.Authentication = AuthenticationLevel.Default;
     options.EnablePrivileges = true;
     return options;
   }
 
   public static ManagementScope ConnectionScope(string machineName, ConnectionOptions options, string path)
   {
     ManagementScope connectScope = new ManagementScope();
     connectScope.Path = new ManagementPath(@"\\" + machineName + path);
     connectScope.Options = options;
     connectScope.Connect();
     return connectScope;
   }
}
public class COMPORTS : MonoBehaviour {

	 public string Name { get; set; }
   public string Description { get; set; }
 
	void Start(){
		foreach (COMPORTS comPort in COMPORTS.GetCOMPortsInfo())
		{
  			Console.WriteLine(string.Format("{0} – {1}", comPort.Name, comPort.Description));
		}
	}
   public COMPORTS() { }      
 
   public static List<COMPORTS> GetCOMPortsInfo()
   {
     List<COMPORTS> COMPORTSList = new List<COMPORTS>();
 
     ConnectionOptions options = ProcessConnection.ProcessConnectionOptions();
     ManagementScope connectionScope = ProcessConnection.ConnectionScope(Environment.MachineName, options, @"\root\CIMV2");
 
     ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
     ManagementObjectSearcher comPortSearcher = new ManagementObjectSearcher(connectionScope, objectQuery);
 
     using (comPortSearcher)
     {
       string caption = null;
       foreach (ManagementObject obj in comPortSearcher.Get())
       {
         if (obj != null)
         {
           object captionObj = obj["Caption"];
           if (captionObj != null)
           {
              caption = captionObj.ToString();
              if (caption.Contains("(COM"))
              {
                COMPORTS COMPORTS = new COMPORTS();
                COMPORTS.Name = caption.Substring(caption.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")",
                                                     string.Empty);
                COMPORTS.Description = caption;
                COMPORTSList.Add(COMPORTS);
              }
           }
         }
       }
     } 
     return COMPORTSList;
   } 
}
*/
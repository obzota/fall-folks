using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public Transform trackedPosition;

    private string logFilePath;

    // Start is called before the first frame update
    void Start()
    {
       logFilePath = Path.Combine(Application.persistentDataPath, "log.txt");
       Log("Application starting");
    }

    // Update is called once per frame
    public void Log(string message)
    {
        DateTime now = DateTime.Now;
        string timestamp = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"[{timestamp}]{message}");
        }
    }

    void Update() {
        var pos = trackedPosition.position;
        Log("Position: " + pos.x + ", " + pos.y + ", " + pos.z);
    }


    void OnApplicationQuit() {
        Log("Application quitting");
    }
}

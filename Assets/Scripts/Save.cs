using MapTests;
using System;
using UnityEngine;

/// <summary>
/// put this behaviour onto a separate object in your scene
/// </summary>
public class Save : MonoBehaviour
{
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HeatTrack.PrintToFile();
            Debug.Log(Application.persistentDataPath);
        }

    }
}

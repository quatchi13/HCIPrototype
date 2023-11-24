using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MapTests;

public class TriggerBehaviours : MonoBehaviour
{
    public Vector2 tileLoc;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("It works!");
        HeatTrack.TrackPos(tileLoc);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HeatTrack.PrintToFile();
        }
        
       
    }

    
}

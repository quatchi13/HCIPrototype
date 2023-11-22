using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class CamSwitcher : MonoBehaviour
{
    [SerializeField]
    private GameObject pCam;

    [SerializeField]
    private GameObject oCam;

    [SerializeField]
    private GameObject rCam;

    private void Start() {

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            pCam.SetActive(!pCam.activeInHierarchy);
        }
        else if(Input.GetKeyDown(KeyCode.O))
        {
            oCam.SetActive(!oCam.activeInHierarchy);
        }
        else if(Input.GetKeyDown(KeyCode.P))
        {
            rCam.SetActive(!rCam.activeInHierarchy);
        }
    }
}

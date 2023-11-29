using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class TriggerPlacement : MonoBehaviour
{
    // default dimensions for unity
    private float quickCount = 0.0f;

    private float slowCount = 0.0f;

    [SerializeField]
    private GameObject triggerPrefab;

    [SerializeField]
    private Transform parentObject;
    // Start is called before the first frame update
    void Start()
    {
        PlaceTriggers();
    }

    private void PlaceTriggers()
    {
        UnityEngine.Debug.Log(transform.position.ToString());
        while (transform.position.z >= -75)
        {
            while (transform.position.x <= 100)
            {
                GameObject g = Instantiate(triggerPrefab, transform.position, Quaternion.identity, parentObject);
                g.GetComponent<TriggerBehaviours>().tileLoc = new Vector2(transform.position.x, transform.position.z);
                transform.position += new Vector3(0.5f, 0, 0);

            }
            transform.position -= new Vector3(200, 0, 0.5f);
            UnityEngine.Debug.Log(transform.position.ToString());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

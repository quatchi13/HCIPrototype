using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{

    public Transform destination;

    // Update is called once per frame
    void Update()
    {
        Vector3 directions = destination.position - transform.position;

        var angles = Mathf.Atan2(directions.x, directions.z) * Mathf.Rad2Deg -90;

        transform.rotation = Quaternion.AngleAxis(angles, Vector3.up);

    }
}


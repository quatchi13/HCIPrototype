using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*[SerializeField]
    private float speed = 1.0f;


    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0,0,0.1f * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0,0,-0.1f * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.1f * speed,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f * speed,0,0);

        }
 

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles += new Vector3(0.0f, yaw, 0.0f);
        
    }*/

    public float movementSpeed = 10f;
    public float horizontalSpeed = 2.0F;
    Rigidbody Rigidbody;

    void Start(){
        Rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.position -= transform.forward * movementSpeed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.A)){
            transform.position -= transform.right * movementSpeed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.D)){
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }
        Rigidbody.MovePosition(transform.position);
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);
    }
}

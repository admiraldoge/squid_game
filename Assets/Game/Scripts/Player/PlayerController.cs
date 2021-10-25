using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    Vector3 Vec;
    public Boolean walk;
    public float walk_speed;
    public Animator ani;
    public Boolean inField = false;
    public Boolean alive = true;
    public float rotationSpeed = 3;
    public float movementSpeed = 20;

    // Start is called before the first frame update  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {

        Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * movementSpeed;
        //Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        //Vec.z += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        if (Input.GetAxis("Horizontal") != 0)
        {
            Vec.z += Math.Abs(Input.GetAxis("Horizontal")) * Time.deltaTime * movementSpeed;
        }
        transform.Rotate(0.0f, Input.GetAxis ("Horizontal") * rotationSpeed, 0.0f);
        //transform.localPosition = Vec;
        if (Input.GetAxis("Vertical") > 0)
        {
            if(Input.GetAxis("Horizontal") > 0) {}
            transform.position += (transform.forward*(float) 0.45)  * Time.deltaTime * movementSpeed;
        } else if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position += (transform.forward*(float) 0.3) * Time.deltaTime * movementSpeed;
        } 
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.position -= (transform.forward*(float) 0.45)  * Time.deltaTime * movementSpeed;
        } else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position += (transform.forward*(float) 0.3) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            walk = true;
        }
        else
        {
            walk = false;
        }
        if (walk)
        {
            ani.SetInteger("arms", 1);
            ani.SetInteger("legs", 1);
        }
        else
        {
            ani.SetInteger("arms", 5);
            ani.SetInteger("legs", 5);
        }
    }

    public void killPlayer()
    {
        alive = false;
    }
    
}
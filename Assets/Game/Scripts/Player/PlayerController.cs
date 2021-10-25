using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 Vec;
    public Boolean walk;
    public float walk_speed;
    public Animator ani;
    public Boolean inField = false;
    public Boolean alive = true;

    // Start is called before the first frame update  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {

        Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;
        transform.localPosition = Vec;
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
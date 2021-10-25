using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollController : MonoBehaviour
{
    Vector3 Vec;
    public float _rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotateHead()
    {
        transform.Rotate(0.0f, 180f, 0.0f, Space.Self);
    }
}

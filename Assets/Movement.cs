using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddForce(new Vector3(70, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.AddForce(new Vector3(-70, 0, 0));
        }
    }
}

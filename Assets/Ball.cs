using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip whistle;
    AudioSource audioData;

    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(new Vector3(0, -20, 0));
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 9;
        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;

        if (transform.position.y < 11)
            {
                transform.position = new Vector3(2, 16, 0);
            }

    }
    void OnCollisionEnter(Collision collision)
    {
        audioData.PlayOneShot(audioData.clip,1);
        myRigidbody.velocity = myRigidbody.velocity + new Vector3(0, 2, 0);
    }

}

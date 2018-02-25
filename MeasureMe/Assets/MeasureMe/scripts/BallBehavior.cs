using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour {

    public Rigidbody rb;
    public Camera mainCamera;

    public GameObject Destination1;
    public GameObject Destination2;
    public GameObject Destination3;
    public GameObject DestinationHome;


     void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Door1"))
        {
            gameObject.transform.position = Destination1.transform.position;
            rb.mass = 1.1f;
            rb.velocity = mainCamera.transform.forward * 5;
            rb.angularVelocity = mainCamera.transform.forward * 5;
        }

        if (col.gameObject.CompareTag("Door2"))
        {
            gameObject.transform.position = Destination2.transform.position;
            rb.mass = 1.1f;
            rb.velocity = mainCamera.transform.forward * 5;
            rb.angularVelocity = mainCamera.transform.forward * 5;
        }

        if (col.gameObject.CompareTag("Door3"))
        {
            gameObject.transform.position = Destination3.transform.position;
            rb.mass = 1.1f;
            rb.velocity = mainCamera.transform.forward * 5;
            rb.angularVelocity = mainCamera.transform.forward * 5;
        }

        if (col.gameObject.CompareTag("DoorHome"))
        {
            gameObject.transform.position = DestinationHome.transform.position;
            rb.mass = 1.1f;
            rb.velocity = mainCamera.transform.forward * 5;
            rb.angularVelocity = mainCamera.transform.forward * 5;
        }
    }
}

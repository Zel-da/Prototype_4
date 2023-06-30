using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    public float speed = 5.0f;

    private GameObject focal_Point;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focal_Point = GameObject.Find("Focal_Point");
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focal_Point.transform.forward * speed * forwardInput);
    }
}

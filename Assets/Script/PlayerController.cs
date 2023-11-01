using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;
    public int power;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //playerRb.AddForce(Vector3.forward * power);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddForce(Vector3.right * power);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(Vector3.left * power);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector3.forward * power);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRb.AddForce(Vector3.back * power);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * power);
        }
    }
}
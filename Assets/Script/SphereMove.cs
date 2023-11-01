using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    Rigidbody rb;
    private bool isFrozen = false;

    public int power;
    public int dampingFactor;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // 最初は重力を無効にする
    }

    void Update()
    {
        
        // 初期のy座標の時に速度をゼロにする
        if (rb.position.y == 20)
        {
            rb.AddForce(-rb.velocity * dampingFactor);

            if (Input.GetKeyDown(KeyCode.Space) && !isFrozen)
            {
                rb.useGravity = true; // ボタンが押されたら重力を有効にする
                isFrozen = true;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector3.right * power);
                rb.AddForce(-rb.velocity * dampingFactor);

            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector3.left * power);
                rb.AddForce(-rb.velocity * dampingFactor);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(Vector3.forward * power);
                rb.AddForce(-rb.velocity * dampingFactor);

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(Vector3.back * power);
                rb.AddForce(-rb.velocity * dampingFactor);
            }
        }
    }
}

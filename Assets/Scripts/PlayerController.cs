using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20;

    // use A and D to control the ring
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + moveSpeed * Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + moveSpeed * Vector3.right * Time.deltaTime;
        }
    }
}

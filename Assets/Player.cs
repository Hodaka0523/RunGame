using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    float movespeed = 10;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, 1 * movespeed);
    }
}

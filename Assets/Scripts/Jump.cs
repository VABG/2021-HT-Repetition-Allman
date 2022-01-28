using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float jumpForce = 100;
    [SerializeField] float sidewaysForce = 3;
    // Start is called before the first frame update
    void Start()
    {
        float i;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
            //rb.AddForce(Vector3.up * jumpForce);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * sidewaysForce);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * sidewaysForce);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTogether : MonoBehaviour
{
    [SerializeField] Rigidbody[] bodies;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < bodies.Length; i++)
            {
                bodies[i].AddForce(Vector2.up * 300);
            }
        }
    }
}

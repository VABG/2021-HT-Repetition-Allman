using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 500);

        Destroy(this.gameObject, 10.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

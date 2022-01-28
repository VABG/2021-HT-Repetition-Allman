using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] GameObject shot;
    [SerializeField] Transform barrel;
    [SerializeField] float rotationAnglePerSecond = 45;
    [SerializeField] float shotDelay = .2f;
    float delayTimer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        delayTimer -= Time.deltaTime;
        transform.Rotate(Vector3.up * Time.deltaTime * rotationAnglePerSecond);

        if (Input.GetKey(KeyCode.Space) && delayTimer < 0)
        {
            Instantiate(shot, barrel.position, barrel.rotation);
            delayTimer = shotDelay;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicPlayer : MonoBehaviour
{
    [SerializeField] float moveSpeedMult = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = 0;

        if (Input.GetKey(KeyCode.A))
        {
            move -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += 1;
        }
        if (Input.GetKeyDown(KeyCode.P)) Time.timeScale = .2f; 
        if (Input.GetKeyUp(KeyCode.P)) Time.timeScale = 1.0f;

        //transform.position += new Vector3(move * 5 * Time.deltaTime, 0, 0);
        transform.position += Vector3.right * move * moveSpeedMult * Time.deltaTime;
    }
}

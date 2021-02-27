using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 250;
    public float sideForce = 750;
    int jumpcount = 1;

    // Start is called before the first frame update
    /* void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 1, forwardForce*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKeyDown("w") && jumpcount == 1)
        {
            rb.AddForce(0, 8, 0, ForceMode.VelocityChange);
            jumpcount -= 1;
        }

        if (rb.position.y <= -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (rb.position.z >= 90)
        {
            FindObjectOfType<GameManager>().win();
        }
    }
}

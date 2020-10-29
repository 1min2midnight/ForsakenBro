using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            transform.position += transform.right * (Time.deltaTime * 5);

        }
        else if (Input.GetKey(KeyCode.A))
        {

            transform.position -= transform.right * (Time.deltaTime * 5);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * (Time.deltaTime * 5);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * (Time.deltaTime * 5);

        }


    }

}

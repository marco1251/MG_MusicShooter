using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    float speed = 8.0f; //player movement speed


    // Update is called once per frame
    void FixedUpdate()
    {

        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); //Get player horizontal and vertical movement
        transform.position += move * speed * Time.deltaTime; //move player when a direction is pressed

    }

    

}

using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    float speed = 13.0f; //player movement speed

    bool isLookingUp;
    bool isLookingLeft;
    bool isLookingDown;
    bool isLookingRight;

    // Update is called once per frame
    void FixedUpdate()
    {

        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); //Get player horizontal and vertical movement
        transform.position += move * speed * Time.deltaTime; //move player when a direction is pressed

        Rotate();
    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (isLookingLeft == false)
            {
                transform.Rotate(Vector3.forward * 90);
                isLookingLeft = true;
            }
        }


    }

}

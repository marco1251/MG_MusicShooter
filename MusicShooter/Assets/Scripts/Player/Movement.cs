using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    float speed = 13.0f; //player movement speed

    bool isLookingUp = true;
    bool isLookingLeft = false;
    bool isLookingDown = false;
    bool isLookingRight = false;

    // Update is called once per frame
    void FixedUpdate()
    {

        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); //Get player horizontal and vertical movement
        transform.position += move * speed * Time.deltaTime; //move player when a direction is pressed

        Rotate();
    }


    void Rotate()
    {
        //rotate left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //rotate left when facing up
            if (isLookingLeft == false && isLookingUp == true)
            {
                transform.Rotate(Vector3.forward * 90);
                isLookingLeft = true;
                isLookingUp = false;
            }

            //rotate left when facing down
            if (isLookingLeft == false && isLookingDown == true)
            {
                transform.Rotate(Vector3.forward * -90);
                isLookingLeft = true;
                isLookingDown = false;
            }

            //rotate left when facing right
            if (isLookingLeft == false && isLookingRight == true)
            {
                transform.Rotate(Vector3.forward * 180);
                isLookingLeft = true;
                isLookingRight = false;
            }

        }

        //rotate right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //rotate right when facing up
            if (isLookingRight == false && isLookingUp == true)
            {
                transform.Rotate(Vector3.forward * -90);
                isLookingRight = true;
                isLookingUp = false;
            }

            //rotate right when facing Down
            if (isLookingRight == false && isLookingDown == true)
            {
                transform.Rotate(Vector3.forward * 90);
                isLookingRight = true;
                isLookingDown = false;
            }

            //rotate right when facing left
            if (isLookingRight == false && isLookingLeft == true)
            {
                transform.Rotate(Vector3.forward * 180);
                isLookingRight = true;
                isLookingLeft = false;
            }
        }

        //look down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //look down when facing up
            if (isLookingDown == false && isLookingUp == true)
            {
                transform.Rotate(Vector3.forward * 180);
                isLookingDown = true;
                isLookingUp = false;
            }

            //look down when facing left
            if (isLookingDown == false && isLookingLeft == true)
            {
                transform.Rotate(Vector3.forward * 90);
                isLookingDown = true;
                isLookingLeft = false;
            }

            //look down when facing right
            if (isLookingDown == false && isLookingRight == true)
            {
                transform.Rotate(Vector3.forward * -90);
                isLookingDown = true;
                isLookingRight = false;
            }
        }

        //look up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //look up when facing left
            if (isLookingUp == false && isLookingLeft == true)
            {
                transform.Rotate(Vector3.forward * -90);
                isLookingUp = true;
                isLookingLeft = false;
            }

            //look up when facing right
            if (isLookingUp == false && isLookingRight == true)
            {
                transform.Rotate(Vector3.forward * 90);
                isLookingUp = true;
                isLookingRight = false;
            }

            //look up when facing down
            if (isLookingUp == false && isLookingDown == true)
            {
                transform.Rotate(Vector3.forward * 180);
                isLookingUp = true;
                isLookingDown = false;
            }
        }


    }

}

using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float moveSpeed; //enemy movement speed
    public float hp; //enemy health



    Transform playerTransform; //location of the player

    //enum of enemy status
    enum AIStatus
    {
        Seek = 0, //follow the player
        Dead = 1 //dead
    }

    private AIStatus status = AIStatus.Seek; //instance of AIStatus

    // Use this for initialization
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; // defining player transform
        hp = 500; //default health
    }

    void CheckStatus() //determine enemy status
    {
        if (hp >= 1)
        {
            status = AIStatus.Seek; //follow player if enemy is alive
        }
        else if (hp <= 0) 
        {
            status = AIStatus.Dead; //die if health reaches 0
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckStatus(); //determine status

        switch (status)
        {
            case AIStatus.Seek:
                Seek();
                break;
            case AIStatus.Dead:
                Dead();
                break;
        }
    }

    void Seek()
    {
        //look at and follow the player
        transform.LookAt(playerTransform.transform);
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, moveSpeed * Time.deltaTime);
    }

    void Dead()
    {
        //destroy the enemy 
        Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        //lower enemy health by 10 when hit by a player bullet
        if (other.gameObject.tag == ("PlayerBullet"))
        {
            hp -= 10; //lower enemy health
            Destroy(other.gameObject); //destroy bullet
        }

        if (other.gameObject.tag == ("Enemy"))
        {
            Destroy(this.gameObject); //destroy both enemies if they collide with each other
        }
        
    }
}

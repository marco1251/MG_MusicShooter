﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float moveSpeed; //enemy movement speed
    public float hp; //enemy health

    public bool isPlayerHit = false; //determines when enemy comes in contact with player

    Transform playerTransform; //location of the player

    //enum of enemy status
    enum AIStatus //enemy state machine
    {
        Seek = 0, //follow the player
        Dead = 1, //dead
        Wait = 2 //stop and wait for the player to respawn
    }

    private AIStatus status = AIStatus.Seek; //instance of AIStatus

    // Use this for initialization
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; // defining player transform
        hp = 200; //default health
    }

    void CheckStatus() //determine enemy status
    {
        if (hp >= 1 && status != AIStatus.Wait) //if enemy health is more than 0 and status != wait
        {
            status = AIStatus.Seek; //follow player if enemy is alive
        }
        else if (hp <= 0)
        {
            status = AIStatus.Dead; //die if health reaches 0
        }

        if (isPlayerHit)
        {
            status = AIStatus.Wait; //stand still for 2 seconds when player is hit
        }

    }

    // Update is called once per frame
    void Update()
    {
        CheckStatus(); //determine status

        switch (status)
        {
            case AIStatus.Seek:
                Seek(); //follow player
                break;
            case AIStatus.Dead:
                Dead(); //destroy this enemy
                break;
            case AIStatus.Wait:
                Stop(); //stop and look at player
                break;
        }
    }

    //event listener
    void OnEnable() //subcribe to the event
    {
        PlayerDeath.PlayerHit += PlayerHit;
    }

    void OnDisable() //unsubscribe from the event
    {
        PlayerDeath.PlayerHit -= PlayerHit;
    }

    void PlayerHit()
    {
        print("player is hit");
        isPlayerHit = true; //makes status = AIStatus.Wait
        StartCoroutine(Wait()); //wait 2 seconds and make status = AIStatus.Seek
    }

    void Seek()
    {
        //look at and follow the player
        transform.LookAt(playerTransform.transform);
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, moveSpeed * Time.deltaTime);
    }

    void Stop()
    {
        //stop movement and look at player
        transform.LookAt(playerTransform.transform);
    }

    void Dead()
    {
        //destroy the enemy 
        Destroy(this.gameObject);
    }

    IEnumerator Wait()
    {
        //all active enemies do the following when event is called
        yield return new WaitForSeconds(1.5f); //wait 1.5 seconds
        isPlayerHit = false; //status no longer = AIStatus.Wait
        status = AIStatus.Seek; //enemy is seeking player after the set time
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

        if (other.gameObject.tag == ("Player"))
        {
            Destroy(this.gameObject); //destroy the enemy that touches the player
        }

    }
}

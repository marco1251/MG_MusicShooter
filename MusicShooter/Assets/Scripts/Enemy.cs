using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float moveSpeed;
    public float hp;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

    Transform playerTransform;

    //enum of enemy status
    enum AIStatus
    {
        Seek = 0,
        Dead = 1
    }

    //instance of AIStatus
    private AIStatus status = AIStatus.Seek;

    // Use this for initialization
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        hp = 100; //default health
    }

    void CheckStatus()
    {
        if (hp >= 1)
        {
            status = AIStatus.Seek;
        }
        else if (hp <= 0)
        {
            status = AIStatus.Dead;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckStatus();

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
        transform.LookAt(playerTransform.transform);
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, moveSpeed * Time.deltaTime);
    }

    void Dead()
    {
        Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("PlayerBullet"))
        {
            hp -= 10;
            print("enemy hit");
        }
    }
}

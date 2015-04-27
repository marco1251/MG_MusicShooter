using UnityEngine;
using System.Collections;

public class EnemyStation : MonoBehaviour
{

    public float hp;

    // Use this for initialization
    void Start()
    {
        hp = 500;
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("PlayerBullet"))
        {
            hp -= 1;
            Destroy(other.gameObject);
        }
    }
}

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

    void OnGUI()
    {
        //GUI.Label(new Rect( this.gameObject.transform.position.x, this.gameObject.transform.position.y, 500 , 60), hp.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
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

using UnityEngine;
using System.Collections;

public class EnemyStation : MonoBehaviour
{

    public float hp;
    public GUIText guiStation;
    private EnemyStationDestroy count; //count stations destroyed

    // Use this for initialization
    void Start()
    {
        hp = 500; //starting health
        guiStation.text = "Health: " + hp.ToString(); //health gui
        guiStation.enabled = true;
        count = GameObject.Find("stationCount").GetComponent<EnemyStationDestroy>(); //reference to station count gameobject 

    }

    void OnGUI()
    {
        //GUI.Label(new Rect( this.gameObject.transform.position.x, this.gameObject.transform.position.y, 500 , 60), hp.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        guiStation.text = "Health: " + hp.ToString(); //text = health 

        //add to station count when a station is destroyed
        if (hp <= 0)
        {
            guiStation.enabled = false;
            count.count++;
            Destroy(this.gameObject);
        }

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("PlayerBullet"))
        {
            hp -= 1; //lower hp when hit by bullet
            Destroy(other.gameObject); //destroy bullet
        }
    }
}

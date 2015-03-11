using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour
{

    public int lives; //player lives
    public GUIText Guitext; //guitext keeping track of player lives
    public GUIText GuiLose; //failure text
    bool hit; //did player get hit?
    Vector3 respawn; //respawn player at center of the screen

    // Use this for initialization
    void Start()
    {
        //defining lives and text
        lives = 3;
        //Guitext.
        Guitext.text = "Lives: " + lives.ToString();
        GuiLose.text = "You Lose!"; 
        Guitext.enabled = true;
        GuiLose.enabled = false;
        hit = false; //true when enemy touches player
        respawn = new Vector3(0, 0, 0); //center of the screen
    }


    void OnTriggerEnter(Collider other)
    {
        //subtrack a life from lives when player touches an enemy
        if (other.gameObject.tag == ("Enemy"))
        {
            Hit();
            hit = true;
            
            if(hit)
            {
                this.gameObject.transform.position = respawn;
                hit = false;
            }
        }

    }

    void Hit() //updates text when player is hit by enemy
    {
        lives -= 1;
        Guitext.text = "Lives: " + lives.ToString(); //update guitext

        if (lives <= 0)
        {
            Guitext.text = "Lives: 0";
            GuiLose.enabled = true;
            Invoke("Reset", 2); //reset
        }
    }

    void Reset() // reset level when lives = 0
    {
        Application.LoadLevel(0);
    }
}

using UnityEngine;
using System.Collections;

public class SceneBackground : MonoBehaviour
{
    public Texture2D Background;

    private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2, 200, 200);

    // Use this for initialization
    void Start()
    {

    }

    private void OnGUI()
    {
        if (Background != null)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Background);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

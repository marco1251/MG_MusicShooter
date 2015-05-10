using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public GUISkin myGUISkin;
    public Texture2D Background;
    public Texture2D Logo;

    public string[] CreditsTextLines = new string[0];

    private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2, 200, 200);

    private string menuState;

    private string main = "main"; //main menu state
    private string options = "options";
    private string credits = "credits";
    private string level = "Level Select";

    private string textToDisplay = "Credits \n";
    private float volume = 1f;

    // Use this for initialization
    void Start()
    {
        menuState = main;

        for (int i = 0; i < CreditsTextLines.Length; i++)
        {
            textToDisplay += CreditsTextLines[i] + "\n";
        }
        textToDisplay += "Press Esc to go back";
    }

    private void OnGUI()
    {
        if (Background != null)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Background);
        }

        if (Logo != null)
        {
            GUI.DrawTexture(new Rect((Screen.width / 2) - 100, 30, 200, 200), Logo);
        }

        GUILayout.Box("Music Shooter");

        GUI.skin = myGUISkin;

        //check UI state
        if (menuState == main)
        {
            WindowRect = GUI.Window(0, WindowRect, menuFunc, "Main Menu");
        }
        if(menuState == level)
        {
            WindowRect = GUI.Window(0, WindowRect, levelFunc, "Level Select");
        }
        if (menuState == options)
        {
            WindowRect = GUI.Window(1, WindowRect, optionsFunc, "Options");
        }
        if (menuState == credits)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), textToDisplay);
        }
    }

    private void menuFunc(int id)
    {
        //buttons
        if(GUILayout.Button("Play Game"))
        {
            Application.LoadLevel("2DSceneLvl1");
        }
        if(GUILayout.Button("Level Select"))
        {
            menuState = level;
        }
        if (GUILayout.Button("Options"))
        {
            menuState = options;
        }
        if(GUILayout.Button("Credits"))
        {
            menuState = credits;
        }
        if(GUILayout.Button("Quit Game"))
        {
            Application.Quit();
        }
    }

    private void optionsFunc(int id)
    {
        GUILayout.Box("Volume");
        volume = GUILayout.HorizontalSlider(volume, 0.0f, 1.0f);
        AudioListener.volume = volume;
        if(GUILayout.Button("Back"))
        {
            menuState = main;
        }
    }

    private void levelFunc(int id)
    {
        if(GUILayout.Button("Level 1"))
        {
            Application.LoadLevel("2DSceneLvl1");
        }
        if (GUILayout.Button("Level 2"))
        {
            Application.LoadLevel("2DSceneLvl2");
        }
        if (GUILayout.Button("Level 3"))
        {
            Application.LoadLevel("2DSceneLvl3");
        }
        if (GUILayout.Button("Back"))
        {
            menuState = main;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(menuState == credits && Input.GetKey(KeyCode.Escape))
        {
            menuState = main;
        }
    }
}

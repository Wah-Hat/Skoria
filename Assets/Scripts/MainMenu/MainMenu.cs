using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // First UI that is shown first.
    public GameObject title;
    public GameObject play;
    public GameObject settings;
    public GameObject exit;


    // Start is called before the first frame update
    void Start()
    {
        if (title == null) title = GameObject.Find("Title");
        if (play == null) play = GameObject.Find("Play");
        if (settings == null) settings = GameObject.Find("Settings");
        if (exit == null) exit = GameObject.Find("Exit");

        // Activating title, play, exit, and settings buttons.
        title.SetActive(true);
        play.SetActive(true);
        settings.SetActive(true);
        exit.SetActive(true);
        //
    }
}

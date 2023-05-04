using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // GameObjects for main UI
    public GameObject title;
    public GameObject play;
    public GameObject settings;
    public GameObject exit;

    // GameObjects for Game Saves
    public GameObject saveScreen;
    public GameObject gameOneBar;
    public GameObject gameTwoBar;
    public GameObject gameThreeBar;
    public GameObject gameOneButton;
    public GameObject gameTwoButton;
    public GameObject gameThreeButton;

    // Start is called before the first frame update
    void Start()
    {
        if (title == null) title = GameObject.Find("Title");
        if (play == null) play = GameObject.Find("Play");
        if (settings == null) settings = GameObject.Find("Settings");
        if (exit == null) exit = GameObject.Find("Exit");

        if (saveScreen == null) saveScreen = GameObject.Find("Save Screen");
        if (gameOneBar == null) gameOneBar = GameObject.Find("GameOne");
        if (gameTwoBar == null) gameTwoBar = GameObject.Find("GameTwo");
        if (gameThreeBar == null) gameThreeBar = GameObject.Find("GameThree");
        if (gameOneButton == null) gameOneButton = GameObject.Find("GameOnePlay");
        if (gameTwoButton == null) gameTwoButton = GameObject.Find("GameTwoPlay");
        if (gameThreeButton == null) gameThreeButton = GameObject.Find("GameThreePlay");

        // Activating main UI game objects.
        title.SetActive(true);
        play.SetActive(true);
        settings.SetActive(true);
        exit.SetActive(true);

        // Deactivating other UI.
        saveScreen.SetActive(false);
        gameOneBar.SetActive(false);
        gameTwoBar.SetActive(false);
        gameThreeBar.SetActive(false);
        gameOneButton.SetActive(false);
        gameTwoButton.SetActive(false);
        gameThreeButton.SetActive(false);
    }

    public void GameSaves()
    {
        saveScreen.SetActive(true);
        gameOneBar.SetActive(true);
        gameTwoBar.SetActive(true);
        gameThreeBar.SetActive(true);
        gameOneButton.SetActive(true);
        gameTwoButton.SetActive(true);
        gameThreeButton.SetActive(true);
    }
}
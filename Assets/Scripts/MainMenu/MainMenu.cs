using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // GameObjects for main UI
    public GameObject title;
    public GameObject play;
    public GameObject settings;
    public GameObject exit;
    public GameObject back;

    // GameObjects for Game Saves
    public GameObject saveScreen;
    public GameObject gameOneBar;
    public GameObject gameTwoBar;
    public GameObject gameThreeBar;
    public GameObject gameOneButton;
    public GameObject gameTwoButton;
    public GameObject gameThreeButton;

    // GameObjects for Settings Screen
    public GameObject settingsScreen;

    // Bools for menus
    public bool saveMenu;
    public bool settingsMenu;

    // Start is called before the first frame update
    void Start()
    {
        if (title == null) title = GameObject.Find("Title");
        if (play == null) play = GameObject.Find("Play");
        if (settings == null) settings = GameObject.Find("Settings");
        if (exit == null) exit = GameObject.Find("Exit");
        if (back == null) back = GameObject.Find("Back");

        if (saveScreen == null) saveScreen = GameObject.Find("Save Screen");
        if (gameOneBar == null) gameOneBar = GameObject.Find("GameOne");
        if (gameTwoBar == null) gameTwoBar = GameObject.Find("GameTwo");
        if (gameThreeBar == null) gameThreeBar = GameObject.Find("GameThree");
        if (gameOneButton == null) gameOneButton = GameObject.Find("GameOnePlay");
        if (gameTwoButton == null) gameTwoButton = GameObject.Find("GameTwoPlay");
        if (gameThreeButton == null) gameThreeButton = GameObject.Find("GameThreePlay");

        if (settingsScreen == null) settingsScreen = GameObject.Find("Settings Screen");

        // Activating main UI game objects.
        title.SetActive(true);
        play.SetActive(true);
        settings.SetActive(true);
        exit.SetActive(true);

        // Deactivating other UI.
        saveScreen.SetActive(false);
        settingsScreen.SetActive(false);
        back.SetActive(false);

        // Sets bools for menus to false
        saveMenu = false;
        settingsMenu = false;

        // Set unused play buttons to inactive here.
    }

    // Opens up the menu with the 3 game saves.
    public void GameSaves()
    {
        saveScreen.SetActive(true);
        back.SetActive(true);

        saveMenu = true;

        // Making play button unable to be clicked in this mode.
        play.GetComponent<Button>().enabled = false;
    }

    // Opens the settings menu.
    public void Settings()
    {
        settingsScreen.SetActive(true);
        back.SetActive(true);

        settingsMenu = true;

        // Making play button unable to be clicked in this mode.
        play.GetComponent<Button>().enabled = false;
        settings.GetComponent<Button>().enabled = false;
    }

    // Closes a menu that is open.
    public void CloseMenu()
    {
        back.SetActive(false);
        play.GetComponent<Button>().enabled = true;
        settings.GetComponent<Button>().enabled = true;
        if (saveMenu) saveScreen.SetActive(false);
        if (settingsMenu) settingsScreen.SetActive(false);
    }

    // Exits the game
    public void Quit()
    {
        Application.Quit();
    }
}
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // GameObjects for main UI
    public GameObject title;
    public GameObject newGame;
    public GameObject continueGame;
    public GameObject settings;
    public GameObject exit;

    // GameObjects for Settings Screen
    public GameObject settingsScreen;

    // Start is called before the first frame update
    void Start()
    {
        if (title == null) title = GameObject.Find("Title");
        if (newGame == null) newGame = GameObject.Find("New Game");
        if (continueGame == null) continueGame = GameObject.Find("Continue");
        if (settings == null) settings = GameObject.Find("Settings");
        if (exit == null) exit = GameObject.Find("Exit");

        if (settingsScreen == null) settingsScreen = GameObject.Find("Settings Screen");

        // Activating main UI game objects.
        title.SetActive(true);
        newGame.SetActive(true);
        continueGame.SetActive(true);
        settings.SetActive(true);
        exit.SetActive(true);

        // Deactivating other UI.
        settingsScreen.SetActive(false);
    }

    // Plays game.
    public void NewGame()
    {
        DisableMenuButtons();
        // creates a new game which will initialize our game data.
        DataPersistanceManager.instance.NewGame();

        // Load gameplay scene which will in turn save the game because of OnSceneLoaded().
        SceneManager.LoadSceneAsync("TestScene");
    }

    public void Continue()
    {
        DisableMenuButtons();
        // Loads the next scene which will also load the game because of OnSceneLoaded().
        SceneManager.LoadSceneAsync("TestScene");
    }

    // Opens the settings menu.
    public void Settings()
    {
        // Setting menu already open.
        if (settingsScreen.activeSelf)
        {
            settingsScreen.SetActive(false);
            newGame.GetComponent<Button>().enabled = true;
            continueGame.GetComponent<Button>().enabled = true;
        }
        // Setting menu closed.
        else
        {
            DisableMenuButtons();
            settingsScreen.SetActive(true);
        }
    }

    private void DisableMenuButtons()
    {
        newGame.GetComponent<Button>().enabled = false;
        continueGame.GetComponent<Button>().enabled = false;
    }

    // Exits the game
    public void Quit()
    {
        Application.Quit();
    }
}
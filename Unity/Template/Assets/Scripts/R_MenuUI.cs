using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class R_MenuUI : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelSelectPanel;
    public string level1Name;
    public string level2Name;
    public string level3Name;
    public string level4Name;
    public string level5Name;

    void Start()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(true);
        } else
        {
            Debug.Log("ERROR: menuPanel missing!");
        }

        if (levelSelectPanel != null)
        {
            levelSelectPanel.SetActive(false);
        } else
        {
            Debug.Log("ERROR: levelSelectPanel missing!");
        }
    }

    //Activates when play button is pressed
    public void Play()
    {
        levelSelectPanel.SetActive(true);
        menuPanel.SetActive(false);
        Debug.Log("Pressed the play button");
    }

    //Activates when settings button is pressed
    public void Settings()
    {
        Debug.Log("Pressed the settings button");
    }

    //Activates when quit button is pressed
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Pressed the quit button");
    }

    public void Level(int index)
    {
        switch (index)
        {
            case 0:
                SceneManager.LoadScene(level1Name);
                break;
            case 1:
                SceneManager.LoadScene(level2Name);
                break;
            case 2:
                SceneManager.LoadScene(level3Name);
                break;
            case 3:
                SceneManager.LoadScene(level4Name);
                break;
            case 4:
                SceneManager.LoadScene(level5Name);
                break;
            default:
                Debug.Log("ERROR: Invalid index!");
                break;
        }
    }
}
    
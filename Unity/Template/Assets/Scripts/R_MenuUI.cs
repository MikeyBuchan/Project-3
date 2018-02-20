using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class R_MenuUI : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelSelectPanel;

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
                //Assign scene
                break;
            case 1:
                //Assign scene
                break;
            case 2:
                //Assign scene
                break;
            case 3:
                //Assign scene
                break;
            case 4:
                //Assign scene
                break;
            default:
                Debug.Log("ERROR: Invalid index!");
                break;
        }
    }
}

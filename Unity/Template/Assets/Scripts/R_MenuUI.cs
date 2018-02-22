using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class R_MenuUI : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelSelectPanel;
    public List<string> levelNames = new List<string>();
    public List<bool> levelLock = new List<bool>();

    void Start()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(true);
        }
        else
        {
            Debug.Log("ERROR: menuPanel missing!");
        }

        if (levelSelectPanel != null)
        {
            levelSelectPanel.SetActive(false);
        }
        else
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
        if (levelLock[index] != true)
        {
            switch (index)
            {
                case 0:
                    SceneManager.LoadScene(levelNames[0]);
                    break;
                case 1:
                    SceneManager.LoadScene(levelNames[1]);
                    break;
                case 2:
                    SceneManager.LoadScene(levelNames[2]);
                    break;
                case 3:
                    SceneManager.LoadScene(levelNames[3]);
                    break;
                case 4:
                    SceneManager.LoadScene(levelNames[4]);
                    break;
                default:
                    Debug.Log("ERROR: Invalid index!");
                    break;
            }
        } else
        {
            Debug.Log("This level is locked!");
        }
    }
}

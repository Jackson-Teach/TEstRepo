using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject splashPanel;
    public GameObject mainPanel;
    public GameObject optionsPanel;

    public enum MenuState
    {
        Splash,
        Main,
        Options
    }

    private MenuState currentState;

    // Start is called before the first frame update
    void Start()
    {
        SetMenuState(MenuState.Splash);
    }

    public void SetMenuState(MenuState newState)
    {
        currentState = newState;

        switch (currentState)
        {
            case MenuState.Splash:
                splashPanel.SetActive(true);
                mainPanel.SetActive(false);
                optionsPanel.SetActive(false);
                break;
            case MenuState.Main:
                splashPanel.SetActive(false);
                mainPanel.SetActive(true);
                optionsPanel.SetActive(false);
                break;
            case MenuState.Options:
                splashPanel.SetActive(false);
                mainPanel.SetActive(false);
                optionsPanel.SetActive(true);
                break;
            default:
                break;
        }
    }
}

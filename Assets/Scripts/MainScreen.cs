using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class MainScreen : MonoBehaviour
{
    public MenuManager menuMan;
    TMP_InputField ikdfsjg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPressed()
    {
        SceneManager.LoadScene("VoxelScene");
    }

    public void OptionsPressed()
    {
        menuMan.SetMenuState(MenuManager.MenuState.Options);
    }

    public void QuitPressed()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    
    public Button mainMenuButton;

    // Start is called before the first frame update
    void Start()
    {
       
        mainMenuButton.onClick.AddListener(LoadMainMenu);
    }

    
    void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
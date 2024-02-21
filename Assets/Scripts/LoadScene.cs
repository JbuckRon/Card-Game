using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : SceneManager
{
    // Calls the different scenes based on the game mode selected
    // Will need events for when the button is clicked and it selects a certain gamemode
    public delegate void ClickAction();
    public static event ClickAction OnClicked();

    enum GameMode{
        MAIN_MENU,
        WAR,
        SLAP_JACK,
        GO_FISH
    }

    public LoadScene()
    {
       
    }

    
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    // Calls the different scenes based on the game mode selected
    // Will need events for when the button is clicked and it selects a certain gamemode

    //[SerializeField] private Button btn_War;
    [SerializeField] private string gameMode;

    void OnEnable()
    {
        GameManager.OnClicked += OnClickLoadScene;
    }
    
    void OnDisable()
    {
        GameManager.OnClicked -= OnClickLoadScene;
    }

    private void OnClickLoadScene()
    {
        GameManager.instance.LoadScene(gameMode);
        
    }
    
}

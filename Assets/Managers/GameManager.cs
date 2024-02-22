using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Only one instance can exist of this in each scene
/// </summary>

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public delegate void ClickAction();
    public static event ClickAction OnClicked;


    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

    }

    public void LoadScene(string gameMode)
    {
        SceneManager.LoadScene(gameMode);
    }


}

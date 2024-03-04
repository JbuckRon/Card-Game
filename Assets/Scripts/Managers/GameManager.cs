using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Only one instance can exist of this in each scene
/// </summary>

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] public CardDeck[] cardDeck = new CardDeck[2];

    public delegate void ClickAction();
    public static event ClickAction OnClicked;


    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        foreach (var plyrCardDeck in cardDeck)
        {
            if (plyrCardDeck == null) Debug.LogError("CardDeck reference is not set in Gamemanager");

        }
    }

    public void LoadScene(string gameMode)
    {
        SceneManager.LoadScene(gameMode);
    }




}

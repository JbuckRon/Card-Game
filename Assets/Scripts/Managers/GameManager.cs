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
   private CardDeck cardDeck;
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

    // Used to set the image to the new deck
    public Sprite CardDeck()
    {

        Sprite card = cardDeck.cardsImages[0]; // Get the top card from the shuffled deck
        cardDeck.cardsImages.RemoveAt(0); // Remove the dealt card from the deck
        return card;
    }


}

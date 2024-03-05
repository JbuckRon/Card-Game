using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SlapJack : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    Sprite topCard;
    Sprite bottomCard;
    int points;
    bool slappable;
    int playerOne;
    int playerTwo;


    public void Flip()
    {
        bottomCard = gameManager.cardDeck[0].GetCurrentCard();
        gameManager.cardDeck[0].RemoveCurrentCard();
        gameManager.cardDeck[0].ShuffleDeck();
        topCard = gameManager.cardDeck[0].GetCurrentCard();
        gameManager.cardDeck[0].RemoveCurrentCard();
        points += 1;

        CheckSlappable();
    }

    public void CheckSlappable()
    {
        if(bottomCard == topCard)
            slappable = true;
    }

    public void Slapped(CardHand hand)
    {
        if (slappable)
        {
            playerOne += points;
            points = 0;
            
            slappable = false;
            CheckWin();
        }
    }

    private void CheckWin()
    {
        if (gameManager.cardDeck[0].cardsImages.Count <= 0)
        {
            if(playerOne > playerTwo)
            {
                Debug.Log("Player 1 wins!!!");
            }
            else
            {
                Debug.Log("Player 2 wins!!!");
            }
        }
    }
}

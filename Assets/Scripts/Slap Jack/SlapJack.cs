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
    [SerializeField] private GameObject slapButton;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null && hit.collider.name.Equals("slapjack"))
            {
                Flip();
            }
            else if (hit.collider.name.Equals("SlapButton"))
            {
                Slapped();
            }
        }
    }

    public void Flip()
    {
        bottomCard = gameManager.cardDeck[0].GetCurrentCard();
        gameManager.cardDeck[0].ShuffleDeck();
        topCard = gameManager.cardDeck[0].GetCurrentCard();
        gameObject.GetComponent<SpriteRenderer>().sprite = topCard;
        points += 1;

        CheckSlappable();
    }

    public void CheckSlappable()
    {
        if (bottomCard == topCard || topCard.name.ToCharArray()[0].Equals('J'))
        {
            slappable = true;
            slapButton.SetActive(true);
        }
    }

    public void Slapped()
    {
        if (slappable)
        {
            playerOne += points;
            points = 0;
            
            slappable = false;
            CheckWin();
        }

        slapButton.SetActive(false);
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

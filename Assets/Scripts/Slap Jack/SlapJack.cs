using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlapJack : MonoBehaviour
{
    [SerializeField] private List<ScriptableObject> deck = new List<ScriptableObject>();
    [SerializeField] private List<ScriptableObject> pile = new List<ScriptableObject>();
    [SerializeField] private CardHand player1;
    [SerializeField] private CardHand player2;
    string winner;
    bool slappable;


    public void Flip()
    {
        ScriptableObject card = deck[Random.Range(0, deck.Count-1)];
        deck.Remove(card);
        pile.Add(card);
        CheckSlappable();
    }

    public void CheckSlappable()
    {
        if (pile[pile.Count - 1].Equals(pile[pile.Count-2]))
        {
            slappable = true;
        }
    }

    public void Slapped(CardHand hand)
    {
        if (slappable)
        {
            foreach (ScriptableObject card in pile)
            {
                hand.DrawCard(card);
            }
            pile.Clear();
            slappable = false;
            CheckWin();
        }
    }

    private void CheckWin()
    {
        if(deck.Count <= 0)
        {
            if (player1.hand.Count > player2.hand.Count)
            {
                winner = "player 1";
            }
            else
            {
                winner = "player 2";
            }
        }
    }
}

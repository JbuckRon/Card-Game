using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDeck : MonoBehaviour
{
    // Will need a List for the images
    public List<Sprite> cardsImages = new List<Sprite>();
    private string folderPath = "Assets/Imports/deck-of-cards/Black Cards"; // Path to set cards dynamically
    private void Start()
    {
        Sprite[] cardSprites = Resources.LoadAll<Sprite>(folderPath);
        foreach (Sprite sprite in cardSprites)
        {
            Debug.Log("Sprite Name " +  sprite.name);
            cardsImages.Add(sprite);
        }
    }

    // Display cards at random. Need to set up a number array or list (Might need to specify values) to compare
    // 52 cards, Could check if it contains the specific name title.

    // Shuffle Cards
    public void ShuffleDeck()
    {
        
        System.Random rand = new System.Random();
        int numberOfCards = cardsImages.Count; // Amount of cards
        Debug.Log("Test");

        while(numberOfCards > 1)
        {
            numberOfCards--; //Removing cards
            int randomCard = rand.Next(numberOfCards);
            Sprite valueOfCard = cardsImages[randomCard];
            cardsImages[randomCard] = cardsImages[numberOfCards];
            cardsImages[numberOfCards] = valueOfCard;

            
        }
           
    }
}

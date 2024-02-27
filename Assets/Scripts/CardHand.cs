using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHand : MonoBehaviour
{
    [SerializeField] private List<ScriptableObject> hand { get; set; }

    public void DrawCard(ScriptableObject card)
    {
        hand.Add(card);
    }

    public void Discard(ScriptableObject card)
    {
        hand.Remove(card);
    }
}

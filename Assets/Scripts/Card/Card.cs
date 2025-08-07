using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card  //model
{
    private readonly CardData cardData;
    public Card(CardData cardData)
    {
        this.cardData = cardData;
        Effect = cardData.Effect;
        Cost = cardData.Cost;
    }
    public Sprite Artwork { get => cardData.Artwork; }
    public string Title { get => cardData.Name; }
    public int Cost { get; set; }
    public string Effect { get; set; }

    public void PerformEffect()
    {
        Debug.Log($"Performing effect: {Effect} of cost {Cost}.");
    }
}

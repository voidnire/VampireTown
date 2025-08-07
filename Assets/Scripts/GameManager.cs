using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<CardData> cardDatas;
    [SerializeField] private CardView cardView;
    private List<Card> deck;
    private void Start()
    {
        deck = new();
        for (int i = 0; i<6;i++)
        {
            CardData cardData = cardDatas[Random.Range(0, cardDatas.Count)];
            Card card = new Card(cardData);
            deck.Add(card);
        }
    }

    // Update is called once per frame
    public void DrawCard()
    {
        Card drawnCard = deck[Random.Range(0, deck.Count)];
        deck.Remove(drawnCard);
        CardView view = Instantiate(cardView);
        view.Setup(drawnCard);
    }
}

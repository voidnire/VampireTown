using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Card Data")] //para criação de instancias 
public class CardData : ScriptableObject
{
    //[field: SerializeField] public string Name;
    //[field: SerializeField] public string Description;
    [field: SerializeField] public int Cost; //damage or heal
    [field: SerializeField] public string Effect;
    [field: SerializeField] public Sprite Artwork;
    [field: SerializeField] public string Name;
}
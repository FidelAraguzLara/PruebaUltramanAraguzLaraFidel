using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;

    public Sprite faction;
    public Sprite rarity;
    public Sprite attribute;

    public int attack;
    public int hp;
    public int cost;

}

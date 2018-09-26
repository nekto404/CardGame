using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public struct CharAndPosition
{
    public Character Character;
    public int PosX;
    public int PosY;

    public CharAndPosition(Character character, int posX, int posY)
    {
        Character = character;
        PosX = posX;
        PosY = posY;
    }
}

public struct CardAndPosition
{
    public Card Card;
    public int PosX;
    public int PosY;

    public CardAndPosition(Card card, int posX, int posY)
    {
        Card = card;
        PosX = posX;
        PosY = posY;
    }
}

public class Group : MonoBehaviour {
    public List<CharAndPosition> Characters;

    public void CreatGroup(List<CharAndPosition> characters)
    {
        Characters = characters;
    }

    public void CreatGroup(List<CardAndPosition> card)
    {
        Characters = new List<CharAndPosition>();
        foreach (var el in card)
        {
            Characters.Add(new CharAndPosition(new Character(el.Card), el.PosX, el.PosY));
        }
    }
}

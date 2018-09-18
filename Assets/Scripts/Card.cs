using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardTypes
{
    War,
    Arc,
    Mag
}

public class Card : MonoBehaviour {

    public string Name;
    public Sprite Icon;
    public int Level;
    public int Exp;
    public int HitPoints;

    public int Atack;
    public int Armor;
    public int MagicDef;
    public int Speed;

    public CardTypes CardType;

    public List<Skill> Skills;
}

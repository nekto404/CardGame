using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name;
    public Sprite Icon;
    public int hitPointsMax;
    public int hitPointsCurent;

    public int manaPointsMax;
    public int manaPointsCurent;

    public int atack;
    public int armor;
    public int magicPower;
    public int speed;

    public List<Spell> Spells;
    public List<Skill> Skills;
}

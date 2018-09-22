﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttackType
{
    dist,
    mil,
    massEnemy,
    ally,
    allies
}

public enum DamageType
{
    pure,
    magic,
    phys,
    heal
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

    public AttackType AttackType;
    public DamageType DamageType;

    public List<Skill> Skills;
}

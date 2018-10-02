using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Character : MonoBehaviour
{
    public string Name;
    public Sprite Icon;
    public int HitPointsMax;
    public int HitPointsCurent;

    public int Atack;
    public int Armor;
    public int MagicDef;
    public int Speed;

    public AtackType AtackType;
    public DamageType DamageType;

    public List<Skill> Skills;

    public Character(Card card)
    {
        Name = card.Name;
        Icon = card.Icon;
        HitPointsCurent = card.HitPoints;
        HitPointsMax = card.HitPoints;
        Atack = card.Atack;
        MagicDef = card.MagicDef;
        Speed = card.Speed;
        AtackType = card.AtackType;
        DamageType = card.DamageType;
        Skills = card.Skills;
    }

    public void GetDamage(int damage, DamageType damageType)
    {
        switch (damageType)
        {
            case DamageType.heal:
                HitPointsCurent += damage;
                if (HitPointsMax < HitPointsCurent)
                    HitPointsCurent = HitPointsMax;
                break;
            case DamageType.pure:
                HitPointsCurent -= damage;
                break;
            case DamageType.magic:
                HitPointsCurent -= damage * (100 - MagicDef) / 100; 
                break;
            case DamageType.phys:
                HitPointsCurent -= damage * (100 - Armor) / 100;
                break;
        }
    }
}

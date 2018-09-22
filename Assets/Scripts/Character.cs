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

    public int atack;
    public int armor;
    public int magicDef;
    public int speed;

    public AttackType AttackType;
    public DamageType DamageType;

    public List<Skill> Skills;

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
                HitPointsCurent -= damage * (100 - magicDef) / 100; 
                break;
            case DamageType.phys:
                HitPointsCurent -= damage * (100 - armor) / 100;
                break;
        }
    }
}

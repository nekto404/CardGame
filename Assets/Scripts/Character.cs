using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public List<Skill> Skills;
}

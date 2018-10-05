using System;
using UnityEngine;

public enum CharacteristicTarget
{
    HitPoints,
    AttackPoints,
    ArmorPoints,
    SpeedPoints
}

public enum EffectValueType
{
    Pecrent,
    Points
}

[Serializable]
public class Effect : MonoBehaviour
{
    public string Name;
    public int Duration;
    public int Value;
    public CharacteristicTarget Target;
    public EffectValueType Type;
}

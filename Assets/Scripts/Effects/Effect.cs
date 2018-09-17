using System;


public enum CharacteristicTarget
{
    HitPoints,
    ManaPoints,
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
public class Effect
{
    public string Name;
    public int Duration;
    public int Value;
    public CharacteristicTarget Target;
    public EffectValueType Type;
}

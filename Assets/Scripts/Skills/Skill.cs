using System;
using System.Collections.Generic;

public enum EffectTarget
{
    Allies,
    Self,
    Enemies,
    Target
}

public enum Triger
{
    StartFigth,
    StartTurn,
    Atack,
    GetDamage
}
[Serializable]
public class Skill
{
    public string Name;
    public EffectTarget TargetType;
    public int Chanse;
    public Triger EffectTriger;
    public List<Effect> Effects;
}

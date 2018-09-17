using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Spell {
    public string Name;
    public int ManaCost;
    public EffectTarget TargetType;
    public List<Effect> Effects;
}

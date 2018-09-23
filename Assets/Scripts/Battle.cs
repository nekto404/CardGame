using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour {

    public Group GroupOne;
    public Group GroupTwo;

    public void AtackEfect(Character character, Character target, bool WithGroupOne)
    {
        if (character.AttackType == AttackType.allies)
        {
            var TargetGroup = WithGroupOne ? GroupOne : GroupTwo;
            foreach (var targetChar in TargetGroup.Characters)
            {
                targetChar.Character.GetDamage(character.atack, character.DamageType);
            }
        }
        else if (character.AttackType == AttackType.massEnemy)
        {
            var TargetGroup = WithGroupOne ? GroupTwo : GroupOne;
            foreach (var targetChar in TargetGroup.Characters)
            {
                targetChar.Character.GetDamage(character.atack, character.DamageType);
            }
        }
        else
        {
            target.GetDamage(character.atack, character.DamageType);
        }
    }

    public List<Character> AvalableTarget(Character character, bool WithGroupOne)
    {
        List<Character> targets = new List<Character>();
        if (character.AttackType == AttackType.allies || character.AttackType == AttackType.ally)
        {
            var TargetGroup = WithGroupOne ? GroupOne : GroupTwo;
            foreach (var targetChar in TargetGroup.Characters)
            {
                targets.Add(targetChar.Character); 
            }
        }
        else if (character.AttackType == AttackType.massEnemy || character.AttackType == AttackType.dist)
        {
            var TargetGroup = WithGroupOne ? GroupTwo : GroupOne;
            foreach (var targetChar in TargetGroup.Characters)
            {
                targets.Add(targetChar.Character);
            }
        }
        else 
        {
            var TargetGroup = WithGroupOne ? GroupTwo : GroupOne;
            foreach (var targetChar in TargetGroup.Characters)
            {
                if (targetChar.posY==1)
                    targets.Add(targetChar.Character);
            }
            if (targets.Count == 0)
            {
                foreach (var targetChar in TargetGroup.Characters)
                {
                    targets.Add(targetChar.Character);
                }
            }
        }
        return targets;
    }
}

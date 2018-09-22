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

}

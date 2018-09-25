using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public struct TurnData
{
    public Character Character;
    public float TimeByTurn;

    public TurnData(Character character,float time)
    {
        Character = character;
        TimeByTurn = time;
    }
}

public class Battle : MonoBehaviour {

    public Group GroupOne;
    public Group GroupTwo;

    private List<TurnData> queue;

    #region MonoBehaviourLogic
    public void Start()
    {
        queue = QueueCreator();
    }
    #endregion

    #region BattleLogic
    public void StartTurn()
    {

    }

    public void EndOfTurn()
    {
        queue.OrderBy(t => t.TimeByTurn);
    }
    #endregion

    #region UtilityLogic
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

    public List<TurnData> QueueCreator(int count=5)
    {
        var queue = new List<TurnData>();
        foreach (var character in GroupOne.Characters)
        {
            var timePerTurn = 1f / character.Character.speed;
            for (var i = 0; i < count; i++)
            {
                queue.Add(new TurnData(character.Character, timePerTurn * i));
            }
        }
        foreach (var character in GroupTwo.Characters)
        {
            var timePerTurn = 1f / character.Character.speed;
            for (var i = 0; i < count; i++)
            {
                queue.Add(new TurnData(character.Character, timePerTurn * i));
            }
        }
        return queue.OrderBy(t => t.TimeByTurn).ToList();
    }
    #endregion

}

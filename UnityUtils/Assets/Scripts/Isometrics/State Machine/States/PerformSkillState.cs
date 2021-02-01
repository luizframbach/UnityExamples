﻿using System.Collections;
using UnityEngine;

public class PerformSkillState : State
{
    public override void Enter()
    {
        base.Enter();
        StartCoroutine(PerformSequence());
    }

    IEnumerator PerformSequence()
    {
        yield return null;

        Turn.Unit.Direction = Turn.Skill.GetComponentInChildren<SkillRange>().GetDirection();
        Turn.Unit.AnimationController.Idle();
        Turn.Unit.AnimationController.Attack();

        Turn.Skill.Effect();
        yield return null;

        CombatLog.CheckActive();
        yield return new WaitForSeconds(1f);

        if (CombatLog.IsOver())
        {
            StateMachine.ChangeTo<MapEndState>();
        }
 
        StateMachine.ChangeTo<TurnEndState>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : playerState
{
    public PlayerIdleState(player _player, playerStateMachine _playerStateMachine, string _animBoolName) : base(_player, _playerStateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        
    }
}

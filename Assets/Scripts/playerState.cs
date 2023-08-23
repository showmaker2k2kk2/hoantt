using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerState 
{
    protected playerStateMachine stateMachine;
    protected player player;
    private string animBoolName;
    public playerState(player _player, playerStateMachine _playerStateMachine, string _animBoolName)

    {
        this.stateMachine = _playerStateMachine;
        this.player = _player;
        this.animBoolName = _animBoolName;
    }
    public virtual void Enter()
    {
        Debug.Log("i enter" + animBoolName);
    }
    public virtual void Exit()
    {
        Debug.Log("i exit" + animBoolName);
    }
    public virtual void Update()
    {
        Debug.Log("i update" + animBoolName);
    }

}

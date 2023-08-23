using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Animator anim;
  public playerStateMachine statemachine { get; private set; }
  public PlayerIdleState idleState { get; private set; }
    public playerMovestate  movestate { get; private set; }
    private void Awake()
    {
        statemachine = new playerStateMachine();
        idleState = new PlayerIdleState(this, statemachine, "idle");
        movestate = new playerMovestate(this, statemachine, "Move");
    }
    void Start()
    {
        statemachine.Initialize(idleState);
        anim = GetComponentInChildren<Animator>();
    }

  
    void Update()
    {
        statemachine.currentState.Update();

    }
}

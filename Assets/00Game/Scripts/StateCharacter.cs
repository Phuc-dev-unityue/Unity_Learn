using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateCharacter : MonoBehaviour
{
    public ICharacterState idleState;
    public ICharacterState runningState;
    public ICharacterState jumpingState;
    private ICharacterState currentState;
    private void Start()
    {
        idleState = new IdleState(this);
        runningState = new RunningState(this);
        jumpingState = new JumpingState(this);

        currentState = idleState;
        currentState.EnterState();
    }
    void TransitionToState(ICharacterState newState)
    {
        currentState.EnterState();
        currentState = newState;
        currentState.EnterState();
    }
}

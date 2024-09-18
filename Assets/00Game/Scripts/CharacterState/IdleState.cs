using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : ICharacterState
{
    private StateCharacter _stateCharacter;
    public IdleState(StateCharacter stateCharacter)
    {
        this._stateCharacter = stateCharacter;
    }
    public void EnterState()
    {
        Debug.Log(" Idle + EnterState");
    }

    public void ExitState()
    {
        Debug.Log(" Idle + ExitState");
    }

    public void UpdateState()
    {
        Debug.Log(" Idle + UpdateState");
    }
}

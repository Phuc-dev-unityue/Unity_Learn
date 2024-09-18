using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : ICharacterState
{
    private StateCharacter _stateCharacter;
    public JumpingState(StateCharacter stateCharacter)
    {
        this._stateCharacter = stateCharacter;
    }
    public void EnterState()
    {
        Debug.Log(" Jumping + EnterState");
    }

    public void ExitState()
    {
        Debug.Log(" Jumping + ExitState");
    }

    public void UpdateState()
    {
        Debug.Log(" Jumping + UpdateState");
    }
}

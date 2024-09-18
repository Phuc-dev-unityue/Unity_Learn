using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningState : ICharacterState
{
    private StateCharacter _stateCharacter;
    public RunningState(StateCharacter stateCharacter)
    {
        this._stateCharacter = stateCharacter;
    }
    public void EnterState()
    {
        Debug.Log(" Running + EnterState");
    }

    public void ExitState()
    {
        Debug.Log(" Running + ExitState");
    }

    public void UpdateState()
    {
        Debug.Log(" Running + UpdateState");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Character character;
    [SerializeField] private InputHander inputHander;
    private void Start()
    {
        inputHander.OnKeyLeft += character.MoveLeft;
    }
}

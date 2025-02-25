using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : BaseManager 
{
    public override string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public override void Initialize()
    {
        _state = "Combat Manager initialized..";
        Debug.Log(_state);
    }

    void Start()  // Ensure initialization when the GameObject starts
    {
        Initialize();
        Debug.Log("CombatManager has been successfully set up!");
    }
}
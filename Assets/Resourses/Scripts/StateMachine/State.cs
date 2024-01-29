using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    protected Playerlist playerlist = Playerlist.Instance;
    protected StateMachineController stateMachineController;

    public State(StateMachineController stateMachineController)
    {
        this.stateMachineController = stateMachineController;
    }

    public abstract void Enter(IBehaviour c);

    public abstract void Update(IBehaviour c);

    public abstract void Exit(IBehaviour c);
}

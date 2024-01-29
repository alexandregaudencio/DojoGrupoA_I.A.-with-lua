using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{

    

    public AttackState(StateMachineController stateMachineController) : base(stateMachineController)
    {
        
    }
    public override void Enter(IBehaviour c)
    {
        c.Attack();

        stateMachineController.ChangeState(stateMachineController.MoveTo);
    }

    public override void Exit(IBehaviour c)
    {

    }

    public override void Update(IBehaviour c)
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

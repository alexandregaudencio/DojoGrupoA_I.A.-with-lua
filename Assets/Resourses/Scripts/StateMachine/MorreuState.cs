using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorreuState : State
{
    // Start is called before the first frame update
    public MorreuState(StateMachineController stateMachineController) : base(stateMachineController)
    {

    }
    public override void Enter(IBehaviour c)
    {
        c.DeactiveProperties(true);
        CooldownBase();
    }

    public override void Exit(IBehaviour c)
    {
        c.DeactiveProperties(false);
    }

    public override void Update(IBehaviour c)
    {
        
    }

    private async void CooldownBase()
    {
        //yield return new WaitForSeconds(0.5f);
        await System.Threading.Tasks.Task.Delay(5000);
        stateMachineController.ChangeState(stateMachineController.MoveTo);
    }
}
    

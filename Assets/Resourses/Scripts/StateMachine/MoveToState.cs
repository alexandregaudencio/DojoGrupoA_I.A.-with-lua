using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToState : State
{
    
    float cooldownMax;
    float cooldownRealese;
    private CharacterBehaviour characterBehaviour;

    
    

    LuaStateIntegration luaStateIntegration;


    public MoveToState(StateMachineController stateMachineController):base (stateMachineController)
    {
       SpawnPlayers.instance.Spawned +=   Initialize;


    }

    

    public void Initialize()
    {
        characterBehaviour = stateMachineController.PlayerScrip.characterBehaviour;
        luaStateIntegration = new LuaStateIntegration(characterBehaviour);
        luaStateIntegration.LoadLuaFile(characterBehaviour.playerScript.Id);

        Debug.Log("Nome: " + luaStateIntegration.Lua.GetString("name"));
        characterBehaviour.playerScript.PlayerName = luaStateIntegration.Lua.GetString("name");

        luaStateIntegration.Lua.RegisterFunction("Print", this, GetType().GetMethod("Print"));
        luaStateIntegration.Lua.RegisterFunction("Attack", this, GetType().GetMethod("Attack"));
        luaStateIntegration.Lua.RegisterFunction("GoToPosition", this, GetType().GetMethod("GoToPosition"));
        luaStateIntegration.Lua.RegisterFunction("ReturnToBase", this, GetType().GetMethod("ReturnToBase"));
        luaStateIntegration.Lua.RegisterFunction("SetNearPlayerDestination", this, GetType().GetMethod("SetNearPlayerDestination"));

        luaStateIntegration.Lua.RegisterLuaClassType(typeof(CharacterBehaviour), typeof(CharacterBehaviour));
        luaStateIntegration.Lua.RegisterLuaClassType(typeof(PlayerScpt), typeof(PlayerScpt));
        luaStateIntegration.Lua.RegisterLuaClassType(typeof(BaseScript), typeof(BaseScript));
        luaStateIntegration.Lua.RegisterLuaClassType(typeof(NavMeshAgent), typeof(NavMeshAgent));
        luaStateIntegration.Lua.RegisterLuaClassType(typeof(Transform), typeof(Transform));
        luaStateIntegration.Lua.RegisterLuaClassType(typeof(Vector3), typeof(Vector3));
        luaStateIntegration.Lua.RegisterLuaClassType(typeof(Playerlist), typeof(Playerlist));
        luaStateIntegration.Lua.RegisterLuaClassType(typeof(List<PlayerScpt>), typeof(List<PlayerScpt>));





    }

    public override void Enter(IBehaviour c)
    {
        //throw new System.NotImplementedException();
       
        characterBehaviour.playerAgent.isStopped = false;



    }

    public override void Exit(IBehaviour c)
    {

        //throw new System.NotImplementedException();
    }


    public override void Update(IBehaviour c)
    {

        luaStateIntegration.SendVariablesToLuaProps();
        luaStateIntegration.TryCallLuaMethod("Update");
    }


    public void GoToPosition(Vector3 position)
    {
        characterBehaviour.GoToPosition(position);
    }

    public void ReturnToBase()
    {
        characterBehaviour.ReturnToBase();
    }


    public void Print(string message)
    {
        Debug.Log(message);
    }

    public void Attack()
    {
        if (!CanAttack()) return;
        stateMachineController.ChangeState(stateMachineController.AttackState);
    }

    public void SetNearPlayerDestination()
    {
        PlayerScpt targetPlayer = playerlist.players[0];

        foreach (PlayerScpt playerScpt in playerlist.players)
        {
            float actualPlayerTargetDistance = Vector3.Distance(characterBehaviour.playerScript.transform.position, targetPlayer.transform.position);
            float nextPlayerDistance = Vector3.Distance(characterBehaviour.playerScript.transform.position, playerScpt.transform.position);
            if (nextPlayerDistance > actualPlayerTargetDistance)
            {
                targetPlayer = playerScpt;
            }
        }

        characterBehaviour.playerAgent.SetDestination(targetPlayer.transform.position);


    }



    bool CanAttack()
    {

        if (cooldownRealese >= cooldownMax) return true;
         return false;
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterBehaviour : IBehaviour
{
    public NavMeshAgent playerAgent;
    public PlayerScpt playerScript;

    //public Playerlist playerlist;

    public CharacterBehaviour(NavMeshAgent navMeshAgent,  PlayerScpt player)
    {
        this.playerScript = player;
        this.playerAgent = navMeshAgent;
        //playerlist = Playerlist.Instance;
    }

    public void Attack()
    {
        playerScript.zonaAtaque.enabled = true;
        //if (zonaAtaque.GetComponent<Espada>().hitjogador)
        CooldownAttack();
        Debug.Log("UOL");
    }

    public void Stop()
    {
        playerAgent.isStopped = true;
    }
    
    //public void Block()
    //{

    //}

    //public void Chase(Vector2 position)
    //{

    //}

    public void GoToPosition(Vector3 position)
    {
        playerAgent.isStopped = false;
        playerAgent.SetDestination(position);

    }

    
    private async void CooldownAttack()
    {
        //yield return new WaitForSeconds(0.5f);
        await System.Threading.Tasks.Task.Delay(500);
        Debug.Log("UOOOL");
        playerScript.zonaAtaque.enabled = false;
    }

    public void DeactiveProperties(bool value)
    {
        
        playerScript.zonapersonagem.enabled = !value;
        playerAgent.isStopped = value;
        
        if (!value)
        {
            return;
        }

        playerScript.zonaAtaque.enabled = !value;
        playerScript.transform.position = playerScript.Base.transform.position;
        playerScript.ResetSouls();
    }

    public void ReturnToBase()
    {
        playerAgent.SetDestination(playerScript.Base.Position);


    }
}

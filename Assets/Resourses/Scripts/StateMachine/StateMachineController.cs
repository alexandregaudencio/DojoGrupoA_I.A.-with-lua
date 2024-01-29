using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineController : MonoBehaviour
{
   [SerializeField] private  PlayerScpt playerScript;
    State currentState;
    private State moveTo;
    private State attackState;
    private State morreuState;



    public PlayerScpt PlayerScrip => playerScript;
    public State MoveTo => moveTo;
    public State AttackState => attackState;
    public State MorreuState => morreuState;

    private void Awake()
    {
         moveTo = new MoveToState(this);
         attackState = new AttackState(this);
         morreuState = new MorreuState(this);
    }


    public void Start()
    {
        //playerScript = GetComponent<PlayerScpt>();

        ChangeState(moveTo);

    }

    public void ChangeState(State newState)
    {
        if (currentState != null)
        {
            currentState.Exit(playerScript.characterBehaviour);
        }

        currentState = newState;
        currentState.Enter(playerScript.characterBehaviour);
        
    }

    private void Update()
    {
        if (playerScript.characterBehaviour == null) return;
        currentState.Update(playerScript.characterBehaviour);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Espada>(out Espada espada))
        {
            ChangeState(MorreuState);
        }
        //Debug.Log("aaaaaaaaaaaaaa");
    }
}

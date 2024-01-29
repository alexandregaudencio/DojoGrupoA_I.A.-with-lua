using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerScpt : MonoBehaviour
{
     public BaseScript Base { get; set; }
    public string PlayerName { get; set; } = "Nome";
    private Renderer renderer;
    private Rigidbody rigidbody;
    private int id = 1;
    public Vector3 worldZero;
    public Collider zonaAtaque;
    public Collider zonapersonagem;
    private Espada espada;
    [SerializeField] private int souls = 0;
    [SerializeField] private Color color;
    public int Id => id;
    
    public event Action<int> changeSouls;
    public event Action<string> changeName;

    private NavMeshAgent playerAgent;
    public CharacterBehaviour characterBehaviour;
    public int Souls => souls;

    public Vector3 Position => transform.position;
    public Timer timer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        playerAgent = GetComponent<NavMeshAgent>();
        espada = GetComponentInChildren<Espada>();
        timer = FindObjectOfType<Timer>();

        characterBehaviour = new CharacterBehaviour(playerAgent, this);

        // worldZero = GameObject.Find("000").transform.position;
    }

    private void Start()
    {
        espada.hit += AddSouls;


        timer.Finish += () =>
        {
            playerAgent.isStopped = true;
            gameObject.SetActive(false);

        };

    }
    private void OnDestroy()
    {
        espada.hit -= AddSouls;
    }
    private void AddSouls(int souls)
    {
        this.souls += souls+1;
        changeSouls?.Invoke(this.souls);
    }

    

    public void ResetSouls()
    {
        this.souls = 0;
        changeSouls?.Invoke(this.souls);
    }

    public void Initialize(int id, Color color, BaseScript basescript ) {
        this.id = id;
        this.color = color;
        this.Base = basescript;
        //renderer.material.SetColor("_Color", Color.red);
        Playerlist.Instance.AddPlayer(this);

    }





}

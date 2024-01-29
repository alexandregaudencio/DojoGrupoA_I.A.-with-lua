using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseScript : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text soulText;
    
    public int idBase;
    private new Renderer renderer;
    private PlayerScpt player;
    public int PlayerSoulsStoraged { get; private set; } = 0;
    public string PlayerName => player.PlayerName;
    public Vector3 Position => transform.position;

    //public event Action<int> SoulsStoragedChange;

    [SerializeField] private Color color;

    private void Update()
    {
        nameText.SetText(PlayerName);
    }

    public static BaseScript instance;
    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        color = UnityEngine.Random.ColorHSV();
        //renderer.material.color = color;

    }
    // Start is called before the first frame update
    public void SpawnPlayer(/*"dados de cada jogador"*/)
    {
        GameObject playerObject = Instantiate(playerPrefab, transform);
        player = playerObject.GetComponent<PlayerScpt>();


        
        player.Initialize(idBase, color, this);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerScpt playerScpt;
        if (!other.TryGetComponent<PlayerScpt>(out playerScpt)) return;
        if (playerScpt.PlayerName != PlayerName) return;
        PlayerSoulsStoraged += playerScpt.Souls;

        soulText.SetText(PlayerSoulsStoraged.ToString());
        playerScpt.ResetSouls();

    }


}

//[Serializable]
//public class BaseData
//{
//    public Color Color { get; set; }
//    public int Id { get; set; }

//    public BaseData(int id, Color color)
//    {
//        Color = color;
//        Id = id;
//    }

//}
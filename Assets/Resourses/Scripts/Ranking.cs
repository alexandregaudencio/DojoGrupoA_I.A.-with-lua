using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    public string Name { get; set; }

    public int Score { get; set; }

    [SerializeField] private SpawnPlayers spawnPlayers;
    [SerializeField] private TMP_Text names;
    [SerializeField] private TMP_Text points;
    //[SerializeField] private TMP_Text orderedNumbers;
    private List<BaseScript> baseScripts;
    // Start is called before the first frame update
    void Start()
    {
        baseScripts = spawnPlayers.ListofBases.ToList();
        spawnPlayers.Spawned += () => { baseScripts = spawnPlayers.ListofBases.ToList(); };

        //Ranking valor1 = new Ranking(name = "teste_01", Score = 100);


        // ranking.Add(valor1);

        baseScripts.Sort((a, b) => b.PlayerSoulsStoraged.CompareTo(a.PlayerSoulsStoraged));

    }

    // Update is called once per frame
    void Update()
    {
        baseScripts.Sort((a, b) => b.PlayerSoulsStoraged.CompareTo(a.PlayerSoulsStoraged));
        UpdateRanking();


    }
    void UpdateRanking()
    {
        names.SetText("");
        points.SetText("");
        for (int i = 0; i < baseScripts.Count; i++)
        {
            names.SetText(string.Concat(names.text, i + 1,"° - ", baseScripts[i].PlayerName) + "\n") ;
            points.SetText(string.Concat(points.text, baseScripts[i].PlayerSoulsStoraged) + "\n");
        }
    } 
}


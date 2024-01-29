using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIControl : MonoBehaviour
{
    [SerializeField] TMP_Text soulsText;
    [SerializeField] TMP_Text nameText;
    [SerializeField] PlayerScpt player;

    void Start()
    {
        player.changeSouls += SetSoulText;

        player.changeName += SetNameText;
    }

    public void OnDestroy()
    {
        player.changeSouls -= SetSoulText;

        player.changeName -= SetNameText;
    }

    void Update()
    {
        SetNameText(player.PlayerName);
    }

    public void SetSoulText(int souls)
    {
        soulsText.SetText(souls.ToString());
    }

    public void SetNameText(string name)
    {
        nameText.SetText(name);
    }
}

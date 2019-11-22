using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{

    public Text NameText;

    void Awake()
    {
        NameText.text = "Player: " + KeepData.PlayerName;
    }
}

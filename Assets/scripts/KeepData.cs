using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName;

    public InputField PlayerNameInput;

  

    void Awake()
    {
        DontDestroyOnLoad(this);

    }
    
    public void Update()
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);

    }
}

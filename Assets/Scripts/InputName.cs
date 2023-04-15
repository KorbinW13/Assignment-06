using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayerName;

    void Start()
    {
        PlayerNameInput.text = PlayerName;
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);
        showPlayerName.text = PlayerName;
    }
}

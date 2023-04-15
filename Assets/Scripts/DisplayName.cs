using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public Text PlayerNameText;
    void Start()
    {
        PlayerNameText.text = InputName.PlayerName;
    }
}

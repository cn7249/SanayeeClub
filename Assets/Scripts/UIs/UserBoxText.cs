using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserBoxText : MonoBehaviour
{
    public Text text;

    private void Update()
    {
        text.text = GameManager.I.PlayerName + "(��)";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterButton : MonoBehaviour
{
    private Text _input;

    private void Awake()
    {
        _input = GameObject.Find("InputTxt").GetComponent<Text>();
    }

    public void OnEnter()
    {
        string name = _input.text;
        GameManager.I.PlayerName = name;

        if (name.Length > 2 && name.Length < 10)
        {
            SceneManager.LoadScene("MainScene");
        }

    }
}

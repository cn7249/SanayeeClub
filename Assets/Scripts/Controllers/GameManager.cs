using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public string PlayerName { get; set; }
    public int PlayerType { get; set; }


    public enum CharacterType
    {
        Knight,
        Wizard
    }

    private void Awake()
    {
        I = this;
    }

}

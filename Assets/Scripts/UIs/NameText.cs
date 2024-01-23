using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class NameText : MonoBehaviour
{
    private CharacterStatsHandler _stats;
    private Text _text;


    private void Awake()
    {
        _stats = GetComponentInParent<CharacterStatsHandler>();
        _text = GetComponent<Text>();
    }

    void Start()
    {
        _text.text = _stats.CurrentStates.name;
    }

}

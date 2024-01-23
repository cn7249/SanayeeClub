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
        // 부모 오브젝트의 컴포넌트를 가져온다
        _stats = GetComponentInParent<CharacterStatsHandler>();
        _text = GetComponent<Text>();
    }

    void Start()
    {
        _text.text = _stats.CurrentStates.name;
    }

}

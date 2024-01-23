using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnightSelectButton : MonoBehaviour
{
    public GameObject selectPopUp;
    public GameObject characterSelectBtn;

    public void OnClick()
    {
        GameManager.I.PlayerType = (int)GameManager.CharacterType.Knight;
        selectPopUp.SetActive(false);
        ChangeButtonSprite();
    }

    private void ChangeButtonSprite()
    {
        string path = "Sprites/knight_f_idle_anim_f0";
        characterSelectBtn.GetComponent<Image>().sprite = Resources.Load<Sprite>(path);
    }
}

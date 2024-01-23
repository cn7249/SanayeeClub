using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WizardSelectButton : MonoBehaviour
{
    public GameObject selectPopUp;
    public GameObject characterSelectBtn;

    public void OnClick()
    {
        GameManager.I.PlayerType = (int)GameManager.CharacterType.Wizard;
        selectPopUp.SetActive(false);
        ChangeButtonSprite();
    }

    private void ChangeButtonSprite()
    {
        string path = "Sprites/wizzard_m_idle_anim_f0";
        characterSelectBtn.GetComponent<Image>().sprite = Resources.Load<Sprite>(path);
    }
}

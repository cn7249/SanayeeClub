using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterSelectButton : MonoBehaviour
{
    public GameObject selectPopUp;

    public void OnClick()
    {
        selectPopUp.SetActive(true);
    }
}

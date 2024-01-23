using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabButton : MonoBehaviour
{
    public GameObject player;
    public GameObject tabBox;
    public GameObject button;

    private bool isClicked = false;
    private float x;
    private float y;
    
    private void Update()
    {
        x = player.transform.position.x;
        y = tabBox.transform.position.y;
    }

    public void OnClick()
    {
        if (!isClicked)
        {
            tabBox.transform.position = new Vector3(x + 9.4f, y, 0);
            button.transform.rotation = Quaternion.Euler(0, 0, 180);
            isClicked = true;
        }
        else
        {
            tabBox.transform.position = new Vector3(x + 13.2f, y, 0);
            button.transform.rotation = Quaternion.Euler(0, 0, 0);
            isClicked = false;
        }
    }
}

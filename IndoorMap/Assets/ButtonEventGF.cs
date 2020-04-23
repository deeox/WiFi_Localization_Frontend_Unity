using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEventGF : MonoBehaviour
{
    public Text txt = null;
    public GameObject map;

    public bool toggle = false;
    public void toggleBtn()
    {
        toggle = !toggle;
        if (toggle) {
            txt.text = "GF OFF";
            map.SetActive(false);
        } else {
            txt.text = "GF ON";
            map.SetActive(true);
        }
    } 
}

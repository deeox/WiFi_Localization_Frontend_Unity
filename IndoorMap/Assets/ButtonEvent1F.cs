using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent1F : MonoBehaviour
{
    public Text txt = null;
    public GameObject map1;
    public GameObject map2;

    public bool toggle = false;
    public void toggleBtn()
    {
        toggle = !toggle;
        if (toggle) {
            txt.text = "1F OFF";
            map1.SetActive(false);
            map2.SetActive(false);
        } else {
            txt.text = "1F ON";
            map1.SetActive(true);
            map2.SetActive(false);
        }
    } 
}

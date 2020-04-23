using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrDistCalc : MonoBehaviour
{
    public GameObject sprite;
    public Text txt = null;

    void Update() {

        Vector3 GF_1 = new Vector3(-11.82f, 0.21f, 7.65f);
        Vector3 GF_2 = new Vector3(-2.91f, 0.21f, 7.65f);
        Vector3 GF_3 = new Vector3(5.96f, 0.21f, 7.65f);
        Vector3 GF_4 = new Vector3(-11.82f, 0.21f, -10.02f);
        Vector3 GF_5 = new Vector3(-2.91f, 0.21f, -10.02f);
        Vector3 GF_6 = new Vector3(-11.82f, 0.21f, -10.02f);
        Vector3 FF_1 = new Vector3(-11.82f, 6.35f, 7.65f);
        Vector3 FF_2 = new Vector3(-2.91f, 6.35f, 7.65f);
        Vector3 FF_3 = new Vector3(5.96f, 6.35f, 7.65f);
        Vector3 FF_4 = new Vector3(-11.82f, 6.35f, -10.02f);
        Vector3 FF_5 = new Vector3(-2.91f, 6.35f, -10.02f);
        Vector3 FF_6 = new Vector3(-11.82f, 6.35f, -10.02f);

        float minDist = float.MaxValue;

        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, GF_1));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, GF_2));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, GF_3));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, GF_4));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, GF_5));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, GF_6));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, FF_1));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, FF_2));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, FF_3));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, FF_4));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, FF_5));
        minDist = Mathf.Min(minDist, Vector3.Distance(sprite.transform.position, FF_6));

        if (Vector3.Distance(sprite.transform.position, GF_1) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nGF_1";
        } else if (Vector3.Distance(sprite.transform.position, GF_2) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nGF_2";
        } else if (Vector3.Distance(sprite.transform.position, GF_3) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nGF_3";
        } else if (Vector3.Distance(sprite.transform.position, GF_4) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nGF_4";
        } else if (Vector3.Distance(sprite.transform.position, GF_5) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nGF_5";
        } else if (Vector3.Distance(sprite.transform.position, GF_6) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nGF_6";
        } else if (Vector3.Distance(sprite.transform.position, FF_1) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nFF_1";
        } else if (Vector3.Distance(sprite.transform.position, FF_2) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nFF_2";
        } else if (Vector3.Distance(sprite.transform.position, FF_3) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nFF_3";
        } else if (Vector3.Distance(sprite.transform.position, FF_4) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nFF_4";
        } else if (Vector3.Distance(sprite.transform.position, FF_5) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nFF_5";
        } else if (Vector3.Distance(sprite.transform.position, FF_6) - minDist == 0.0f)
        {
            txt.text = "Current Location:\nFF_6";
        } 

    }

}
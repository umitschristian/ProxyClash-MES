using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanalC : MonoBehaviour { 
int counter;

    public GameObject GOD;
    public void hidePanal()
    {
        counter++;
        if ( counter % 2 == 1)
        {
            gameObject.SetActive(false);

        }
        else
        {
            gameObject.SetActive(true);
        }
    }





} 
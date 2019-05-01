using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanalC : MonoBehaviour { 
int counter;
    public GameObject Panal;

    public void hidePanal()
    {
        counter++;
        if (counter % 2 == 1)
        {
            Panal.gameObject.SetActive(false);

        }
        else
        {
            Panal.gameObject.SetActive(true);
        }
    }





} 
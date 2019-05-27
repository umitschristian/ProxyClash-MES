using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{

    public GameObject Var2;
    public GameObject Var;
    /*
   private GameObject mygameo;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        mygameo = GameObject.FindGameObjectWithTag("Text");

        if (Input.GetKey(KeyCode.M))
        {
       
             mygameo.SetActive(true);
        }
        else
        {
            mygameo.SetActive(false);
          
        }
    }

    public static List<T > FindObjectsOfTypeAll<T>()
    {
        List<T> results = new List<T>();
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            var s = SceneManager.GetSceneAt(i);
            if (s.isLoded)
            {
                var allGameObjects = s.GetRootGameObjects();
                for (int j = 0; j < allGameObjects.Length; j++)
                {
                    var go = allGameObjects[j];
                    results.AddRange(go.GetComponentsInChildren<T>(true));
                }
            }
        }
        return results;
    }
    */
    public void Update()
    {


        if (Input.GetKey(KeyCode.M))
        {
            Var2.gameObject.SetActive(true);
        }
        else
        {
            Var2.gameObject.SetActive(false);
        }


        if (Input.GetKey(KeyCode.M)) {
            Var.gameObject.SetActive(true);
        }
        else
        {
            Var.gameObject.SetActive(false);
        }


    }
}


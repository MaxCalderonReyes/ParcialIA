using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnem : MonoBehaviour
{
    public float C1;
    public float C2;
    
    public float GCONT1;
    public float GCONT2;

    public GameObject prefabE1;
    public GameObject PrefabE2;
  
    void Update()
    {
        C1+=Time.deltaTime;
        C2+=Time.deltaTime;
        if(C1>GCONT1){
         
            C1 = 0;
            if (prefabE1 != null)
            {
                GameObject enemi = Instantiate(prefabE1);
                GameManager.instancia.Enemi1.Add(prefabE1);
                enemi.transform.position = this.transform.position;
            }
        }
        if(C2>GCONT2){
            C2=0;

            if (PrefabE2 != null)
            {
                GameObject enemi = Instantiate(PrefabE2);
                GameManager.instancia.Enemi2.Add(PrefabE2);
                enemi.transform.position = this.transform.position;
            }
        }
    }
}

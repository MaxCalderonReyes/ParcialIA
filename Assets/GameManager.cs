using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
  public List<GameObject> objetivos = new List<GameObject>();
  public List<GameObject> Enemi1=new List<GameObject>();
  public List<GameObject> Enemi2=new List<GameObject>();
   private void Awake()
    {
        if (instancia == null) instancia = this;
    

    }
    void Start()
    {
            objetivos.Add(Points.instancias.gameObject);
    }

  
    void Update()
    {
        
    }
}

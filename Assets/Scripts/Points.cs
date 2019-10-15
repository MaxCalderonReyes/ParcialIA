using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
public static Points instancias;
private void Awake() {
    if(instancias==null)instancias=this;
    
}

  public void Start() {
   
   GameManager.instancia.objetivos.Add(gameObject);
    
 } 
  
  

}

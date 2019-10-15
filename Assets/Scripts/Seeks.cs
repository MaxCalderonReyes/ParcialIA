using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeks : MonoBehaviour
{
    public static Seeks instancia;
    private Vector3 Velocidad;
    private Vector3 Desired;
    private Vector3 Steer;
    public float MaxSteer;
    public float MaxSpeed;
    
    public int n = 0;

   
    private void Start()
    {
        
        
        


    }

    void Update()
    {


        Separate();

        Seek();
    }
    public void Seek()
    {
        float rango = 1;

        print(n);
        float Distancia = (GameManager.instancia.objetivos[n].transform.position - transform.position).magnitude;
        if (Distancia > rango)
        {
            Desired = (GameManager.instancia.objetivos[n].transform.position - transform.position).normalized * MaxSpeed;
            Steer = Vector2.ClampMagnitude(Desired - Velocidad, MaxSteer);
            Velocidad += Steer * Time.deltaTime;
            transform.position += Velocidad * Time.deltaTime;
        }
        if (Distancia < rango)
        {
            n += 1;
        }
        if (n >= GameManager.instancia.objetivos.Count)
        {
            Autodestruir();
        }


    }
    public Vector3 flee()
    {
        float range = 4;
        Vector3 steer = Vector3.zero;
        Vector3 desired = Vector3.zero;
        Vector3 difference = (GameManager.instancia.objetivos[n].transform.position - transform.position);
        float distance = difference.magnitude;
        desired = -difference.normalized * MaxSpeed;


        if (distance < range)
        {

            steer = Vector3.ClampMagnitude(desired - Velocidad, MaxSteer);
        }
        else
        {
            steer = Vector3.zero;
        }

        // cálculo de los demás vectores
        return steer;
    }
    public Vector3 Separate()
    {
        Vector3 steer = Vector3.zero;

        for (int i = 0; i < GameManager.instancia.objetivos.Count; i++)
        {
            steer += flee();
        }

        return steer;
    }
    public void Autodestruir()
    {
        GameManager.instancia.Enemi1.Remove(this.gameObject);
 GameManager.instancia.Enemi2.Remove(this.gameObject);
        Destroy(gameObject);
    }

}

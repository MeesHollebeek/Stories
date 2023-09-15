using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurenKapot : MonoBehaviour
{
    public Enemy Script;
    public bool Destroyed = false;
    public GameObject Bakker;
    public GameObject Point1;
    public GameObject Point2;
   

    void Start()
    {
        Script.GetComponent<Enemy>();
    }

    void OnMouseDown()
    {
        Destroyed= true;
        Script.enabled = true;
        Bakker.GetComponent<NavigationBaker>().enabled = true;
        Destroy(gameObject);

       Point1.tag = "player";
       Point2.tag = "player";
      






    }
}

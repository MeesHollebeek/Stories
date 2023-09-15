using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurenKapot : MonoBehaviour
{
    public Enemy Script;
    public bool Destroyed = false;
    public GameObject Bakker;

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

    }
}

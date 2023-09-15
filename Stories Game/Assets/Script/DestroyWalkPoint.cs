using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWalkPoint : MonoBehaviour
{
    public Enemy Script;

    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;

    void Start() 
    {
        Script.GetComponent<Enemy>();
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");

        if (other.gameObject.CompareTag("Speler"))
        {
            Script.enabled = false;
            gameObject.SetActive(false);
            Debug.Log("hit");

            Point1.SetActive(true);
            Point2.SetActive(true);
            Point3.SetActive(true);
            Point4.SetActive(true);

            Point1.tag = "wrong";
            Point2.tag = "wrong";
            Point3.tag = "wrong";
            Point4.tag = "wrong";
        }
    }
}
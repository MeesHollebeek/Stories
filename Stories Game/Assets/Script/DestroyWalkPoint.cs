using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWalkPoint : MonoBehaviour
{
    public Enemy Script;
    public EnemyEnemy Script2;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;

    void Start() 
    {
        Script.GetComponent<Enemy>();
        Script2.GetComponent<EnemyEnemy>();
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");

        if (other.gameObject.CompareTag("Speler"))
        {
            gameObject.tag = "wrong";
            Script.enabled = false;
            Script2.enabled = false;
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWalkPoint : MonoBehaviour
{
    public Enemy Script;
    public EnemyEnemy Script2;
    public GameObject NavPlayer;
    public GameObject NavEnemy;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;

    void Start() 
    {
        Script.GetComponent<Enemy>();
        Script2.GetComponent<EnemyEnemy>();
    }

    void Update()
    {

        if(NavPlayer.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled == false)
        {
            gameObject.tag = "wrong";
        }
    }


    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Speler"))
        {
            gameObject.tag = "wrong";
            Script.enabled = false;
            Script2.enabled = false;
            NavPlayer.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            NavEnemy.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            gameObject.SetActive(false);
  

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
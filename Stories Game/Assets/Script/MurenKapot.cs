using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurenKapot : MonoBehaviour
{
    public Enemy Script;
    public EnemyEnemy Script2;
    public GameObject NavPlayer;
    public GameObject KapotteMuur;
    public GameObject NavEnemy;
    public NavigationBaker nav;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;


    void Start()
    {
        Script.GetComponent<Enemy>();
        Script2.GetComponent<EnemyEnemy>();
        nav.GetComponent<NavigationBaker>();
    }

    void OnMouseDown()
    {
        NavPlayer.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        NavEnemy.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        Script.enabled = true;
        Script2.enabled = true;
        nav.enabled = true;
        KapotteMuur.SetActive(true);

        Destroy(gameObject);

       Point1.tag = "player";
       Point2.tag = "player";
       Point3.tag = "Enemyplayer";
       Point4.tag = "Enemyplayer";

       
    }


}

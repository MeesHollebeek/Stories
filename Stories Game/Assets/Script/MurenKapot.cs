using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurenKapot : MonoBehaviour
{
    public Enemy Script;
    public EnemyEnemy Script2;
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
        
        Debug.Log("bakken");
       
        Debug.Log("bakken2");
        Script.enabled = true;
        Script2.enabled = true;
        nav.enabled = true;

        Destroy(gameObject);

       Point1.tag = "player";
       Point2.tag = "player";
       Point3.tag = "Enemyplayer";
       Point4.tag = "Enemyplayer";

       
    }


}

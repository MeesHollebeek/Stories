using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWalkPoint : MonoBehaviour
{
    public Color WalkPointColor;
    public Renderer myRenderer;
    public Enemy Script;
    public EnemyEnemy Script2;
    public GameObject NavPlayer;
    public GameObject Buddy;
    public GameObject NavEnemy;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;
    public GameObject moveSFX;

    void Start() 
    {
        Script.GetComponent<Enemy>();
        Script2.GetComponent<EnemyEnemy>();
        myRenderer = gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        WalkPointColor = new Color(50, 0, 0, 1);
        myRenderer.material.color = WalkPointColor;

        if (NavPlayer.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled == false)
        {
            gameObject.tag = "wrong";
        }

        if(gameObject.tag == "player" || gameObject.tag == "Enemyplayer")
        {
            Debug.Log("Change!");
            myRenderer.material.color = new Color(0, 50, 0, 1);

        }
        if (!Buddy.activeSelf)
        {
            gameObject.SetActive(false);
        }


    }


    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Speler") && gameObject.tag == "player" || gameObject.tag == "Enemyplayer")
        {
            gameObject.tag = "wrong";
            Script.enabled = false;
            Script2.enabled = false;
            NavPlayer.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            NavEnemy.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            moveSFX.SetActive(false);
            


            StartCoroutine(DelayEnable());

            Point1.tag = "wrong";
            Point2.tag = "wrong";
            Point3.tag = "wrong";
            Point4.tag = "wrong";
        }
    }

    private IEnumerator DelayEnable()
    {
        yield return new WaitForSeconds(0.2f);
       
        gameObject.tag = "wrong";
        Point1.SetActive(true);
        Point2.SetActive(true);
        Point3.SetActive(true);
        Point4.SetActive(true);
        gameObject.SetActive(false);



    }
}
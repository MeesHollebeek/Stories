using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject NavPlayer;
    public GameObject Walkpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(!Walkpoint.activeSelf && NavPlayer.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled == true)
        {
            StartCoroutine(Wait());
        } 
    }

    private IEnumerator Wait()
    {

        yield return new WaitForSeconds(5);

        Walkpoint.SetActive(true);

    }
}

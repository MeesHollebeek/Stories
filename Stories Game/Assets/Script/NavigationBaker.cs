using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationBaker : MonoBehaviour
{
    public GameObject Bakker;
    public NavMeshSurface surfaces;

    // Use this for initialization
    void Start()
    {
        
        
    }
    void Update()
    {
        surfaces.BuildNavMesh();
        if (Bakker.GetComponent<NavigationBaker>().enabled = true)
        {
            StartCoroutine(UpdateNav());
        }
        
    }

    private IEnumerator UpdateNav()
    {
        yield return new WaitForSeconds(0.1f);

        Bakker.GetComponent<NavigationBaker>().enabled = false;
          

        
    }

}

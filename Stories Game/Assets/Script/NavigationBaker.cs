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
        StartCoroutine(UpdateNav());
        
    }
    void Update()
    {
        surfaces.BuildNavMesh();
    }

    private IEnumerator UpdateNav()
    {
        yield return new WaitForSeconds(1f);

       
        Bakker.GetComponent<NavigationBaker>().enabled = false;

        
    }

}

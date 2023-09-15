using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChange : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {


        if (other.gameObject.CompareTag("wall"))
        {
            Debug.Log("Changed");
        }
    }
}

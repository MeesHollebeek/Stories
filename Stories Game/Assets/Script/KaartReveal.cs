using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaartReveal : MonoBehaviour
{
    public GameObject Verhaal1Lezen;
    public GameObject Verhaal1;


    void OnMouseDown()
    {
        Verhaal1Lezen.SetActive(true);
        Verhaal1.SetActive(false);

    }
}

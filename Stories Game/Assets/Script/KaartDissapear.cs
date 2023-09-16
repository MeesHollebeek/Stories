using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaartDissapear : MonoBehaviour
{
    public GameObject Verhaal1Lezen;
    public GameObject Verhaal1;


    void OnMouseDown()
    {
        Verhaal1Lezen.SetActive(false);
        Verhaal1.SetActive(true);

    }
}

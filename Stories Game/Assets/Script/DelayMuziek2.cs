using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayMuziek2 : MonoBehaviour
{
    public GameObject Muziek2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RemoveOthers());
    }

    private IEnumerator RemoveOthers()
    {

        yield return new WaitForSeconds(15f);

        Muziek2.SetActive(true);

    }
}

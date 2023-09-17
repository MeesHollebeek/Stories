using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDelayMuziek : MonoBehaviour
{
    public GameObject Muziek3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RemoveOthers());
    }

    private IEnumerator RemoveOthers()
    {

        yield return new WaitForSeconds(15f);

        Muziek3.SetActive(true);

    }
}

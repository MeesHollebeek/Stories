using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickRemove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Remove());
    }

    private IEnumerator Remove()
    {

        yield return new WaitForSeconds(6f);
        gameObject.SetActive(false);


    }
}

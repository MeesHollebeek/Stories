using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickRemove : MonoBehaviour
{
    public SchudCheck Schud;
  
    // Start is called before the first frame update
    void Start()
    {
        Schud.AAN = true;
        StartCoroutine(Remove());
        

    }

    private IEnumerator Remove()
    {
        yield return new WaitForSeconds(.5f);
        Schud.AAN = false;
        yield return new WaitForSeconds(6f);
        gameObject.SetActive(false);


    }
}

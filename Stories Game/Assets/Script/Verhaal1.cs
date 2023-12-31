using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verhaal1 : MonoBehaviour
{
    [SerializeField] private GameObject Trigger;
    [SerializeField] private GameObject FinishScreen;
    [SerializeField] private GameObject DoodScreen;
    [SerializeField] private GameObject Zwaard;
    [SerializeField] private GameObject Prinses;
    [SerializeField] private GameObject Einde;
    [SerializeField] private GameObject DoodSFX;

    public bool ZwaardPakken = false;
    public bool EindeBehaald = false;







    private int loopCount = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DonkereRider")
        {
            // BoxCollider BC = other.gameObject.GetComponent<BoxCollider>();
            // BC.enabled = true;
            DoodSFX.SetActive(true);
            Debug.Log("Dood");
            DoodScreen.SetActive(true);
            Destroy(gameObject);

        }



        // Rigidbody R = Trigger.GetComponent<Rigidbody>();
        if (other.gameObject.tag == "Zwaard" && !ZwaardPakken)
        {
           // BoxCollider BC = other.gameObject.GetComponent<BoxCollider>();
           // BC.enabled = true;
            loopCount++;
            ZwaardPakken = true;
            Debug.Log("Zwaard op ge pakt");
            Zwaard.SetActive(false);

        }

       
        if (other.gameObject.tag == "Prinses" && ZwaardPakken)
        {
            BoxCollider BC = other.gameObject.GetComponent<BoxCollider>();
            BC.enabled = true;
            loopCount++;
            EindeBehaald = true;
            Prinses.SetActive(false);

        }

        
        if (other.gameObject.tag == "Einde" && EindeBehaald)
        {
            BoxCollider BC = other.gameObject.GetComponent<BoxCollider>();
            BC.enabled = true;
            loopCount++;
            Einde.SetActive(false);

        }

        if (loopCount == 4)
        {
            //einde scherm in beeld
            Debug.Log("Verhaal1Gehaald");
            FinishScreen.SetActive(true);

        }

    }
}

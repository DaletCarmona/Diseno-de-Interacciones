using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    bool isInsideZone = false;

    public bool item;

    /*
    public virtual void Interact()
    {
        Debug.Log("Interactuando.");
    }
    */


    public void PickUp()
    {
        Debug.Log("Levantando Item");
        Destroy(gameObject, 1f);
    }
    /*
    public void SetGazedAt(bool gazedAt)
    {
        if (gazedAt)
        {
            item = true;
        }
        else
        {
            item = false;
        }
    }*/
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsDalet : MonoBehaviour
{
    bool isInsideZone = false;
    GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*
    public void SensorSignal()
    {
        Debug.Log("Enciende Luces");
        light.enable;
    }
    */
    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        if (!isInsideZone)
        {
            //light.enable;
            isInsideZone = true;
            Debug.Log("Prende luces");
        }
        else
        {
            //light.disable;
            isInsideZone = false;
            Debug.Log("Apaga luces");
        }

    }

}

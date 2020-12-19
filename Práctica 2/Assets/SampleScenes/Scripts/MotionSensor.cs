using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionSensor : MonoBehaviour
{
    bool isInsideZone = false;

    void SensorSignal()
    {
        Debug.Log("Se cruzó el sensor.");
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        isInsideZone = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInsideZone)//Input.GetKeyDown(KeyCode.E))
        {
            SensorSignal();
        }
    }
}

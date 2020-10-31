using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUIPanel;
    public GameObject inventoryTextPanel;

    void Start()
    {
        inventoryUIPanel.SetActive(false);
        inventoryTextPanel.SetActive(false);
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryUIPanel.SetActive(!inventoryUIPanel.activeSelf);
            inventoryTextPanel.SetActive(!inventoryTextPanel.activeSelf);
        }
    }
}

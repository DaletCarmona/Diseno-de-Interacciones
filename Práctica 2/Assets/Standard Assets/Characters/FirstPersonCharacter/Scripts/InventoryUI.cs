using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUIPanel;
    public GameObject inventoryTextPanel;
    private Inventory inventory;

    void Start()
    {
        //inventory = FindObjectOfType<Inventory>();
        inventory = Inventory.InventoryInstance;
        if (inventory == null)
        {
            return;
        }
        inventoryUIPanel.SetActive(false);
        inventoryTextPanel.SetActive(false);
        inventory.onChange += UpdateUI;
    }

    
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire2"))//(Input.GetKeyDown(KeyCode.I))
        {
            inventoryUIPanel.SetActive(!inventoryUIPanel.activeSelf);
            inventoryTextPanel.SetActive(!inventoryTextPanel.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        Slot[] slots = GetComponentsInChildren<Slot>();
        for(int i = 0; i<slots.Length; i++)
        {
            if(i<inventory.items.Count)
            {
                slots[i].SetItem(inventory.items[i]);
            }
            else 
            {
                slots[i].Clear();
            }
        }
    }
}

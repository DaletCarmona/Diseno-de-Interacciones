using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int space = 10;
    public List<Item> items = new List<Item>();

    public void Add(Item item)
    {
        if(items.Count < space)
        {
            items.Add(item);
        }
        else 
        {
            Debug.LogWarning("Espacio insuficiente!");
        }

    }

    public void Remove(Item item)
    { 
        if(items.Contains(item))
        {
            items.Remove(item);
        }
        else
        {
            Debug.LogWarning("No tienes uno de esos...");//item no está en el inventario
        }
    }
}

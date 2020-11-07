using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Nueva Pocion", menuName = "Inventario/Pocion/PocionHP")]

public class PocionHP : Item
{
    // Start is called before the first frame update
    public override void Use()
    {
        Debug.Log("Curando 50 HP.");
    }
}

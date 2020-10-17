using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : Interactable
{

    public override void Interact()
    {
        gameObject.transform.Translate(1, 1, 1);
    }
}

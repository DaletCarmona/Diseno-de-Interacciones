using System;
using System.Collections;
using System.Security.Policy;
using UnityEngine;

public class SaveOrb : Interactable
{

    public override void Interact()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.blue);
    }
}

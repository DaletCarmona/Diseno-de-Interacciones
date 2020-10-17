using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Interactable
{
    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Dalet\Documents\GitHub\Diseno-de-Interacciones\Práctica 2\Assets\smw_coin.wav");
    public override void Interact() 
    {
        //Debug.Log("Ding!");
        player.Play();

    }

}

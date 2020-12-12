using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Watsson.Examples;

public class VoiceInteractable : MonoBehaviour
{
    private VoiceCommandProcessor commandProcessor;

    // Start is called before the first frame update
    void Start()
    {
        commandProcessor = VoiceCommandProcessor.Instance;
        commandProcessor.onVoiceCommand += VoiceInteract;
    }


    // Update is called once per frame
    public void VoiceInteract(string action)
    {
        Debug.Log("Voice Interact: " + action);
    }
}


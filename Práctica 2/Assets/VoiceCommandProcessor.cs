using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IBM.Watsson.Examples
{
    
    public class VoiceCommandProcessor : MonoBehaviour
    {
        static protected VoiceCommandProcessor s_VoiceInstance;
        static public VoiceCommandProcessor Instance { get { return s_VoiceInstance; } }

        public delegate void OnVoiceCommand(string action);
        public OnVoiceCommand onVoiceCommand;

        public List<string> actions;

        // Start is called before the first frame update
        void Awake()
        {
            s_VoiceInstance = this;
        }

        void Create(string transcript)
        {
            // validar commando
            string[] words = transcript.Split(' ');
            foreach(var word in words)
            {
                if (actions.Contains(word))
                {
                    if(onVoiceCommand != null)
                    {
                        onVoiceCommand.Invoke(word);
                    }
                    break;
                }
            }
            //ejecutar solo si no hay objeto accionable
            // utilizar el voice interactable script
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

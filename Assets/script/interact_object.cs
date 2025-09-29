using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    [TextArea(3, 5)] public string introText;   // Texto inicial (po�tico)
    [TextArea(3, 5)] public string option1Text; // Opci�n orgullo/rencor
    [TextArea(3, 5)] public string option2Text; // Opci�n humildad/reflexi�n
    private bool alreadyInteracted = false;
    public void Interact()
    {
        if(alreadyInteracted) return; 

        DialogueManager.Instance.StartInteraction(this);
        alreadyInteracted = true; 
    }
}

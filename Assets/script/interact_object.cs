using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    [TextArea(3, 5)] public string introText;   // Texto inicial (poético)
    [TextArea(3, 5)] public string option1Text; // Opción orgullo/rencor
    [TextArea(3, 5)] public string option2Text; // Opción humildad/reflexión
    private bool alreadyInteracted = false;
    public void Interact()
    {
        if(alreadyInteracted) return; 

        DialogueManager.Instance.StartInteraction(this);
        alreadyInteracted = true; 
    }
}

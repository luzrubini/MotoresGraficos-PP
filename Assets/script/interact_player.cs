using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRange = 3f; // distancia m�xima para interactuar
    public LayerMask interactableLayer; // asign� la capa "Interactuable"

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Chequea si hay un objeto interactuable cerca
            Collider[] hits = Physics.OverlapSphere(transform.position, interactionRange, interactableLayer);

            if (hits.Length > 0)
            {
                // Tomamos el primero que encontremos (pod�s ordenar por distancia si quer�s)
                InteractionObject obj = hits[0].GetComponent<InteractionObject>();

                if (obj != null)
                {
                    obj.Interact();
                    Debug.Log("Interaccion� con: " + obj.name);
                }
            }
            else
            {
                Debug.Log("No hay nada cerca para interactuar.");
            }
        }
    }

    // Para debug visual: ver el rango en el editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactionRange);
    }
}

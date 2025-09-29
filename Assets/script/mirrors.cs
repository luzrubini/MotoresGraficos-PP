using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorState : MonoBehaviour
{
    [Header("Etapas de grietas (intacto ? roto)")]
    public Material[] crackStages;  // arrastrá aquí los 3 materiales en el Inspector

    private Renderer rend;
    private int currentStage = 0;

    void Start()
    {
        rend = GetComponent<Renderer>();

        if (crackStages.Length > 0)
            rend.material = crackStages[0]; // espejo intacto al inicio
    }

    public void AddCrack()
    {
        if (currentStage < crackStages.Length - 1)
        {
            currentStage++;
            rend.material = crackStages[currentStage];
        }
    }

    public void ResetMirror()
    {
        currentStage = 0;
        rend.material = crackStages[0];
    }
}

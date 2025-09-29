using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    public GameObject dialoguePanel;
    public TMP_Text introTextUI;
    public TMP_Text option1TextUI;
    public TMP_Text option2TextUI;

    private InteractionObject currentObject;
    private bool isChoosing = false;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    void Update()
    {
        if (isChoosing)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                ChooseOption(1);
            if (Input.GetKeyDown(KeyCode.Alpha2))
                ChooseOption(2);
        }
    }

    public void StartInteraction(InteractionObject obj)
    {
        currentObject = obj;
        dialoguePanel.SetActive(true);
        introTextUI.gameObject.SetActive(true);
        option1TextUI.gameObject.SetActive(true);
        option2TextUI.gameObject.SetActive(true);
        introTextUI.text = obj.introText;
        option1TextUI.text = "1 - " + obj.option1Text;
        option2TextUI.text = "2 - " + obj.option2Text;

        isChoosing = true;
        Time.timeScale = 0; // pausa el juego mientras elegimos
    }

    void ChooseOption(int choice)
    {
        isChoosing = false;
        introTextUI.gameObject.SetActive(false);
        option1TextUI.gameObject.SetActive(false);
        option2TextUI.gameObject.SetActive(false);
        dialoguePanel.SetActive(false);
        Time.timeScale = 1; // reanuda el juego

        if (choice == 1)
        {
            // Orgullo → espejo se rompe
            MirrorState[] mirrors = FindObjectsOfType<MirrorState>();
            foreach (MirrorState m in mirrors)
            {
                m.AddCrack();
            }

            Debug.Log("Respuesta orgullosa elegida.");
        }
        else if (choice == 2)
        {
            // Humildad → podrías limpiar niebla, bajar sonidos oscuros
            Debug.Log("Respuesta humilde elegida.");
        }
    }
}

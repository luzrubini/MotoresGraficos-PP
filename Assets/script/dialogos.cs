using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntroSequence : MonoBehaviour
{
    public TMP_Text subtitleText;
    public GameObject tutorialUI;
    public PlayerMovement playerController;

    private PlayerMovement GetPlayerController()
    {
        return playerController;
    }

    //public Interact playerInteract;           

    void Start()
    {
        playerController.enabled = false;
        //playerInteract.enabled = false;

        StartCoroutine(PlayIntro());
    }

    IEnumerator PlayIntro()
    {
        tutorialUI.SetActive(true);
        subtitleText.gameObject.SetActive(true);

        subtitleText.text = "�Qu� qu� es este lugar? El aire es denso, como si estuviera respirando cenizas. No es mi casa� y sin embargo, todo me recuerda a ella.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "???: No te enga�es, Gabriel. No es tu casa lo que ves, sino la cicatriz de tu alma. Has despertado en el purgatorio.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Gabriel: El purgatorio� �como en los versos que aprend� de ni�o? Dante, las terrazas, los pecados� �es esto un castigo o un sue�o febril?";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "???: No es castigo, ni tampoco sue�o. Es camino. El purgatorio es un umbral, un lugar de tr�nsito. Aqu� las almas vienen a expiar lo que las ata, a enfrentar aquello que ocultaron hasta de s� mismas. Solo as�, el peso se vuelve liviano y la subida posible.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Gabriel: Entonces� estoy muerto. Lo �ltimo que recuerdo es el estruendo de un choque, el vidrio quebr�ndose, y despu�s� oscuridad.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "???: Muerte? Ll�malo como quieras. Aqu� lo importante no es c�mo llegaste, sino si sabr�s salir. Has cargado con culpas, orgullos y silencios demasiado tiempo. El purgatorio no los olvida.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Gabriel: �Y t�� qui�n eres para guiarme?";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "???: Un compa�ero de viaje, conocido como Virgilio. Ya estuve aqu�, hace siglos, con otro que crey� poder escribir la verdad de este lugar. Dante lo llam� Comedia. Pero t� bien sabes, Gabriel, que los libros mienten� o callan. Aqu� ver�s lo que ni �l se atrevi� a poner en sus cantos.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Virgilio: El camino ser� largo y pesado, pero no estar�s solo. Yo caminar� contigo. Prep�rate: deber�s mirar lo que negaste, aceptar lo que rechazaste y elegir qu� parte de ti merece permanecer. Recuerda esto: cada decisi�n tendr� un eco.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Virgilio: Camina con WASD. Ac�rcate y presiona E para enfrentar lo que se esconde en los objetos. El viaje ya comenz�.";
        
        yield return new WaitForSeconds(5f);

        subtitleText.text = "";
        tutorialUI.SetActive(false);
        subtitleText.gameObject.SetActive(false);
        playerController.enabled = true;
        //playerInteract.enabled = true;
    }
}

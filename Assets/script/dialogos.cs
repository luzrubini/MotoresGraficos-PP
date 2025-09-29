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

        subtitleText.text = "¿Qué… qué es este lugar? El aire es denso, como si estuviera respirando cenizas. No es mi casa… y sin embargo, todo me recuerda a ella.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "???: No te engañes, Gabriel. No es tu casa lo que ves, sino la cicatriz de tu alma. Has despertado en el purgatorio.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Gabriel: El purgatorio… ¿como en los versos que aprendí de niño? Dante, las terrazas, los pecados… ¿es esto un castigo o un sueño febril?";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "???: No es castigo, ni tampoco sueño. Es camino. El purgatorio es un umbral, un lugar de tránsito. Aquí las almas vienen a expiar lo que las ata, a enfrentar aquello que ocultaron hasta de sí mismas. Solo así, el peso se vuelve liviano y la subida posible.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Gabriel: Entonces… estoy muerto. Lo último que recuerdo es el estruendo de un choque, el vidrio quebrándose, y después… oscuridad.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "???: Muerte? Llámalo como quieras. Aquí lo importante no es cómo llegaste, sino si sabrás salir. Has cargado con culpas, orgullos y silencios demasiado tiempo. El purgatorio no los olvida.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Gabriel: ¿Y tú… quién eres para guiarme?";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "???: Un compañero de viaje, conocido como Virgilio. Ya estuve aquí, hace siglos, con otro que creyó poder escribir la verdad de este lugar. Dante lo llamó Comedia. Pero tú bien sabes, Gabriel, que los libros mienten… o callan. Aquí verás lo que ni él se atrevió a poner en sus cantos.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Virgilio: El camino será largo y pesado, pero no estarás solo. Yo caminaré contigo. Prepárate: deberás mirar lo que negaste, aceptar lo que rechazaste y elegir qué parte de ti merece permanecer. Recuerda esto: cada decisión tendrá un eco.";
        yield return new WaitForSeconds(3f);

        subtitleText.text = "Virgilio: Camina con WASD. Acércate y presiona E para enfrentar lo que se esconde en los objetos. El viaje ya comenzó.";
        
        yield return new WaitForSeconds(5f);

        subtitleText.text = "";
        tutorialUI.SetActive(false);
        subtitleText.gameObject.SetActive(false);
        playerController.enabled = true;
        //playerInteract.enabled = true;
    }
}

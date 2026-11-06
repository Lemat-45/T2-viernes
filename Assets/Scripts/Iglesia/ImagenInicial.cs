using System.Collections;
using UnityEngine;
using Yarn.Unity;

public class ImagenInicial : MonoBehaviour
{
    public CanvasGroup grupo;
    public float segundosVisible = 2f;
    public float duracionFundido = 1f;

    [Header("Opcional: iniciar el diálogo al terminar")]
    public DialogueRunner runner;
    public string nodoInicial = "Interrogatorio3";

    IEnumerator Start()
    {
        grupo.alpha = 1f;
        yield return new WaitForSeconds(segundosVisible);

        float t = 0f;
        while (t < duracionFundido)
        {
            t += Time.deltaTime;
            grupo.alpha = 1f - t / duracionFundido;
            yield return null;
        }

        grupo.alpha = 0f;
        gameObject.SetActive(false);

        if (runner != null) runner.StartDialogue(nodoInicial);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class YarnScripts : MonoBehaviour
{
     [YarnCommand("cambiar_escena")]
    public static void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}


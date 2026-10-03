using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class hitmark24 : MonoBehaviour
{
    public float perfectDistance = 0.5f;  
    public float okDistance = 1.0f;       
    public float maxHitDistance = 1.8f;
    public GameObject currentreciever;

    void Start() 
    {

    }
    void Update()
    {
        
    }

    public void arrows(InputAction.CallbackContext context)
    {
        //por si se le olvido lema de dentro de 3 días esto es lo que pasa si la flecha en cuestión es presionada
        if (context.performed)
        {
            GameObject targetArrow = FindClosestArrowright();

            if (targetArrow != null)
            {
                // calcula la distancia entre el hitmark y la flecha más cercana
                float distance = Vector2.Distance(currentreciever.transform.position, targetArrow.transform.position);

                if (distance <= perfectDistance)
                {
                    Debug.Log($"epa Distance: {distance}"); //para revisar estoy mamado del object checker ajsjs
                    targetArrow.SetActive(false);
                    SUSPICION.caso.AddSuspicionmisshit(-5);
                }
                else if (distance <= okDistance)
                {
                    Debug.Log($"puesss que uno diga le dió ps NO Distance: {distance}");
                    targetArrow.SetActive(false);
                    SUSPICION.caso.AddSuspicionmisshit(1);
                }
                else
                {
                    SUSPICION.caso.AddSuspicionmisshit(5);
                    Debug.Log($"fallo Distancia: {distance}");
                }
            }
            else
            {
                // No arrows are on screen or near the hitmark at all
                Debug.Log("no hay nada ome sapo");
            }
        }
    }

    // Helper method to look through the scene and find the closest valid arrow
    private GameObject FindClosestArrowright()
    {
        GameObject[] arrows = GameObject.FindGameObjectsWithTag("arrowtap");
        GameObject closest = null;
        float shortestDistance = Mathf.Infinity;

        foreach (GameObject arrow in arrows)
        {
            // Only consider active arrows
            if (!arrow.activeInHierarchy) continue;
            float distance = Vector2.Distance(currentreciever.transform.position, arrow.transform.position);
            if (distance < shortestDistance && distance <= maxHitDistance)
            {
                shortestDistance = distance;
                closest = arrow;
            }
        }

        return closest;
    }
}
//RECUERDA QUE ESTA VAINA SE SOLUCIONA HACIENDO UN OBJETO NUEVO DIFERENTE AL QUE ESTÉ FUNCIONANDO ACTUALMENTE, PUEDES TRATAR DE SEPARAR LOS HITMARKS PERO POR AHORA TRATA ESO ESTOY MUY CANSADO POR AHORA PARA SEGUIR

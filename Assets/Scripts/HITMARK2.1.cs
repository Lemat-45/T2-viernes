using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class hitmark21 : MonoBehaviour
{
    public float perfectDistance = 0.5f;  
    public float okDistance = 1.0f;       
    public float maxHitDistance = 1.8f;   

    public int suspicion = 0;

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
            GameObject targetArrow2 = FindClosestArrow();

            if (targetArrow2 != null)
            {
                // calcula la distancia entre el hitmark y la flecha más cercana
                float distance = Vector2.Distance(transform.position, targetArrow2.transform.position);

                if (distance <= perfectDistance)
                {
                    Debug.Log($"epa Distance: {distance}");
                    targetArrow2.SetActive(false);
                    SUSPICION.caso.AddSuspicionmisshit(-5);
                }
                else if (distance <= okDistance)
                {
                    Debug.Log($"puesss que uno diga le dió ps NO Distance: {distance}");
                    targetArrow2.SetActive(false);
                    SUSPICION.caso.AddSuspicionmisshit(1);
                }
                else
                {
                    SUSPICION.caso.AddSuspicionmisshit(5);
                    Debug.Log($"fallo Distancia: {distance}");
                    TriggerMissPenalty();
                }
            }
            else
            {
                // No arrows are on screen or near the hitmark at all
                Debug.Log("Miss! No arrows close enough to hit.");
                TriggerMissPenalty();
            }
        }
    }

    // Helper method to look through the scene and find the closest valid arrow
    private GameObject FindClosestArrow()
    {
        GameObject[] arrows = GameObject.FindGameObjectsWithTag("arrowvert");
        GameObject closest = null;
        float shortestDistance = Mathf.Infinity;

        foreach (GameObject arrow in arrows)
        {
            // Only consider active arrows
            if (!arrow.activeInHierarchy) continue;

            float distance = Vector2.Distance(transform.position, arrow.transform.position);

            // Is this arrow closer than previous ones, and within our maximum hitting window?
            if (distance < shortestDistance && distance <= maxHitDistance)
            {
                shortestDistance = distance;
                closest = arrow;
            }
        }

        return closest;
    }

    private void TriggerMissPenalty()
    {
        // Wrapper handling for safety
        if (SUSPICION.caso != null)
        {
            
        }
    }
}

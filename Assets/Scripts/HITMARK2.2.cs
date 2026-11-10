using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class hitmark22 : MonoBehaviour
{
    public bool pressed;
    public float perfectDistance = 0.8f;
    public float okDistance = 1.0f;
    public float maxHitDistance = 2.3f;
    public GameObject currentreciever;
    public GameObject Detective;
    public Animator Detanima;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        Detanima = Detective.GetComponent<Animator>();
    }
    void Update()
    {

    }

    public void arrows(InputAction.CallbackContext context)
    {
        //por si se le olvido lema de dentro de 3 días esto es lo que pasa si la flecha en cuestión es presionada
        if (context.performed)
        {
            StartCoroutine(keypressed());
            GameObject targetArrow = FindClosestArrowizq();

            if (targetArrow != null)
            {
                // calcula la distancia entre el hitmark y la flecha más cercana
                float distance = Vector2.Distance(currentreciever.transform.position, targetArrow.transform.position);

                if (distance <= perfectDistance)
                {
                    Debug.Log($"epa Distance: {distance}"); //para revisar estoy mamado del object checker ajsjs
                    targetArrow.SetActive(false);
                    SUSPICION.caso.AddSuspicionmisshit(0.6f);
                }
                else if (distance <= okDistance)
                {
                    Debug.Log($"puesss que uno diga le dió ps NO Distance: {distance}");
                    targetArrow.SetActive(false);
                    SUSPICION.caso.AddSuspicionmisshit(-0.7f);
                }
                else
                {
                    SUSPICION.caso.AddSuspicionmisshit(-0.9f);
                    Debug.Log($"fallo Distancia: {distance}");
                }
            }
            else
            {
                SUSPICION.caso.AddSuspicionmisshit(-0.3f);
                // No arrows are on screen or near the hitmark at all
                Debug.Log("no hay nada ome sapo");
            }
        }
    }

    // Helper method to look through the scene and find the closest valid arrow
    private GameObject FindClosestArrowizq()
    {
        GameObject[] arrows = GameObject.FindGameObjectsWithTag("arrowtap");
        Debug.Log($"[{gameObject.name}] receiver pos {currentreciever.transform.position} | flechas: {arrows.Length}");
        foreach (var a in arrows)
            Debug.Log($"   {a.name} activa:{a.activeInHierarchy} pos:{a.transform.position} dist:{Vector2.Distance(currentreciever.transform.position, a.transform.position)}");
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
    IEnumerator keypressed()
    {
        Detanima.SetBool("up?", false);
        Detanima.SetBool("right?", false);
        animator.SetBool("pressed", true);
        Detanima.SetBool("left?", true);
        Detanima.SetBool("NOTIN?", false);
        yield return new WaitForSeconds(0.5f);

        animator.SetBool("pressed", false);
        Detanima.SetBool("left?", false);
        Detanima.SetBool("NOTIN?", true);
    }
}
//RECUERDA QUE ESTA VAINA SE SOLUCIONA HACIENDO UN OBJETO NUEVO DIFERENTE AL QUE ESTÉ FUNCIONANDO ACTUALMENTE, PUEDES TRATAR DE SEPARAR LOS HITMARKS PERO POR AHORA TRATA ESO ESTOY MUY CANSADO POR AHORA PARA SEGUIR

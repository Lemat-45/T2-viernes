using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class hitmark : MonoBehaviour
{
    public GameObject incollision=null;
    public int suspiction = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void arrows(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (incollision != null)
            {
                incollision.gameObject.SetActive(false);
            }
            else
            {
                SUSPICION.caso.AddSuspicionmisshit(1);
            }
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("arrowtap"))
        {
            incollision = collision.gameObject;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("arrowtap"))
        {
            incollision = null;
        }
    }


}

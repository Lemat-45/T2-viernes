using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class hitmark : MonoBehaviour
{
    public bool leftactive = false;

    public int suspiction = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(InputAction.CallbackContext context)
    {
        
    }
    public void arrows ()
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("arrowtap"))
        {
            incollisionarrow = true;
            if (leftactive ==true)
            {
                Destroy(collision.gameObject);
            }
        }
        else
        {
            incollisionarrow = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("arrowtap")&&leftactive == true)
        {
            
            Destroy(collision.gameObject);
        }
        else if (leftactive==true)
        {
            suspiction += 1;
        }
    }

}

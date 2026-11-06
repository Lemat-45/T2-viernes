using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class CamMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void arrowup(InputAction.CallbackContext context)
    {
        transform.position = new Vector3(0f, 0.25f, 0);
        StartCoroutine(waitbeforreturn());
    }
    public void arrowdown(InputAction.CallbackContext context)
    {
        transform.position = new Vector3(0f, -0.25F, 0);
        StartCoroutine(waitbeforreturn());
    }
    public void arrowright(InputAction.CallbackContext context)
    {
        transform.position = new Vector3(0.25f, 0, 0);
        StartCoroutine(waitbeforreturn());
    }   
    public void arrowleft(InputAction.CallbackContext context)
    {   
        transform.position = new Vector3(-0.25f, 0, 0);
        StartCoroutine(waitbeforreturn());
    }
    IEnumerator waitbeforreturn()
    {
        yield return new WaitForSeconds(0.2f);
        transform.position = new Vector3(0f, 0, 0);
    }
}

using UnityEngine;

public class miss : MonoBehaviour
{
    public GameObject incollision=null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
            incollision = collision.gameObject;
            incollision.gameObject.SetActive(false);
            SUSPICION.caso.AddSuspicionmiss();
    }
}

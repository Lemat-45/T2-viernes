using UnityEngine;
using System.Collections;

public class SUSPICION : MonoBehaviour
{
    public float suspicion = 12f;
    public GameObject flameleft;
    public GameObject flameright;
    public GameObject lastarrow;
    public GameObject Detective;
    public Animator Detanima;
    public static SUSPICION caso;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        caso = this;
        Detanima = Detective.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flameleft.transform.position.x > -suspicion)
        {
            flameleft.transform.position -= new Vector3(2f, 0, 0) * Time.deltaTime;
        }
        else if (flameleft.transform.position.x < -suspicion)
        {
            flameleft.transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
        }
        if (flameright.transform.position.x > suspicion)
        {
            flameright.transform.position -= new Vector3(2f, 0, 0) * Time.deltaTime;
        }
        else if (flameright.transform.position.x < suspicion)
        {
            flameright.transform.position += new Vector3(2f, 0, 0) * Time.deltaTime;
        }
        if (!lastarrow.activeSelf)
        {
            if (suspicion > 7)
            {
                //trusted
            }
            else if (suspicion <= 7)
            {
                //untrusted
            }
        }
    }
    public void AddSuspicionmisshit(float amount)
    {
        if (amount < 0)
        {

            StartCoroutine(BAD());
        }
        suspicion += amount;
        if (suspicion >= 12)
        {
            suspicion = 12;
        }
        if (suspicion < 2)
        {
            suspicion = 2;
        }
    }
    public void AddSuspicionmiss()
    {
        StartCoroutine(BAD());
        suspicion -= 0.9f;
        if(suspicion >= 2)
        {
            suspicion = 2;
            Debug.Log("lo cogiero nmijo");
        }
    }
    IEnumerator BAD()
    {
        Detanima.SetBool("left?", false);
        Detanima.SetBool("up?", false);
        Detanima.SetBool("right?", false);
        Detanima.SetBool("fail?", true);
        yield return new WaitForSeconds(0.5f);
        Detanima.SetBool("fail?", false);

    }
}



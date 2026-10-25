using UnityEngine;

public class SUSPICION : MonoBehaviour
{
    public float suspicion = 12f;
    public GameObject flameleft;
    public GameObject flameright;
    public static SUSPICION caso;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        caso = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (flameleft.transform.position.x > -suspicion)
        {
            flameleft.transform.position -= new Vector3(1f, 0, 0) * Time.deltaTime;
        }
        else if (flameleft.transform.position.x < -suspicion)
        {
            flameleft.transform.position += new Vector3(1f, 0, 0) * Time.deltaTime;
        }
        if (flameright.transform.position.x > suspicion)
        {
            flameright.transform.position -= new Vector3(1f, 0, 0) * Time.deltaTime;
        }
        else if (flameright.transform.position.x < suspicion)
        {
            flameright.transform.position += new Vector3(1f, 0, 0) * Time.deltaTime;
        }
    }
    public void AddSuspicionmisshit(float amount)
    {
        suspicion += amount;
        if (suspicion >= 12)
        {
            suspicion = 12;
        }
        if (suspicion < 3)
        {
            suspicion = 3;
            //aqui la funcion de game over
        }
    }
    public void AddSuspicionmiss()
    {
        suspicion -= 0.9f;
        if(suspicion >= 0)
        {
            Debug.Log("lo cogiero nmijo");
            //aqui la funcion de game over
        }
    }
}



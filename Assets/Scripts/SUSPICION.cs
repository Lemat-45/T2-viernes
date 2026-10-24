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
        if (flameleft.transform.position.x > suspicion)
        {
            flameleft.transform.position -= new Vector3(0.3f, 0, 0) * Time.deltaTime;
        }
        else if (flameleft.transform.position.x < suspicion)
        {
            flameleft.transform.position += new Vector3(0.3f, 0, 0) * Time.deltaTime;
        }
    }
    public void AddSuspicionmisshit(float amount)
    {
        suspicion += amount;
        if (suspicion >= 103)
        {
            Debug.Log("lo cogiero nmijo");
            //aqui la funcion de game over
        }
        if (suspicion < 3)
        {
            suspicion = 3;
        }
    }
    public void AddSuspicionmiss()
    {
        suspicion -= 10;
        if(suspicion >= 0)
        {
            Debug.Log("lo cogiero nmijo");
            //aqui la funcion de game over
        }
    }
}



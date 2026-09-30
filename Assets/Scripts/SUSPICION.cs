using UnityEngine;

public class SUSPICION : MonoBehaviour
{
    public int suspicion = 0;
    public static SUSPICION caso;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        caso = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddSuspicionmisshit(int amount)
    {
        suspicion += amount;
        if (suspicion >= 100)
        {
            Debug.Log("lo cogiero nmijo");
        }
        if (suspicion < 0)
        {
            suspicion += -amount;
        }
    }
    public void AddSuspicionmiss()
    {
        suspicion += 10;
        if(suspicion >= 100)
        {
            Debug.Log("lo cogiero nmijo");
        }
    }
}



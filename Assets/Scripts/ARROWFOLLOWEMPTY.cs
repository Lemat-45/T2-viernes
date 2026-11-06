using UnityEngine;

public class ARROWFOLLOWEMPTY : MonoBehaviour
{
    public GameObject Following;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Following.transform.position*Time.deltaTime;
    }
}

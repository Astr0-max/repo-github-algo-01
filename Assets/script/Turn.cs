using UnityEngine;

public class turn : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Je suis Awake");

    }

    private void OnEnable()
    {
        Debug.Log("Je suis Enabled");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("je suis update");
    }


    private void OnDestroy()
    {

        Debug.Log("je suis dead");

    }


}




using UnityEngine;

public class tourne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Debug.Log("je suis awake");
    }

    // Update is called once per frame
    void OnEnable()
    {
        Debug.Log("je suis enabled");
        
    }
    private void Update()
    {

        Debug.Log("je suis updater");
    }


    private void OnDestroy()
    {

        Debug.Log("je suis mort");
    }


}

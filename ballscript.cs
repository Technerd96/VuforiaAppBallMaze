using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{
    public GameObject plane;
    public GameObject point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<plane.transform.position.y-10)
        {
            transform.position = point.transform.position;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pared"))
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("chocaste");
            // transform.position = point.transform.position;
            transform.position = point.transform.position;
        }
    }

}

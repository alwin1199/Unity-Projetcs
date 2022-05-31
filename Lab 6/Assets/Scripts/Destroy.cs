using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("OK");
            RaycastHit hit;
            
            if (Physics.Raycast(transform.position,transform.forward,out hit,100))
            {
                Debug.Log(hit.transform.name);
                BoxCollider bc = hit.collider as BoxCollider;
                if(bc.gameObject.tag=="Enemy")
                {
                    Debug.Log(bc);
                    Destroy(bc.gameObject);
                }
            }
        }
        
    }
}

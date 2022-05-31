using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOn : MonoBehaviour
{
    public GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter()
    {
        player.GetComponent<Renderer>().material.color = Color.black;
        Debug.Log("Hit");
        Invoke("Reset",3);
           

    }

    // Update is called once per frame
    void Reset()
    {
        player.transform.position = new Vector3(0, 1, 0);
    }
}

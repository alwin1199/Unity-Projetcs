using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpereRotate : MonoBehaviour
{
    public float radius;
    public GameObject player;
    public GameObject sphere;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        
        sphere.transform.position = new Vector3(1, 1, 1);
        sphere.transform.localScale = new Vector3(radius, radius, radius);
        player.transform.position= new Vector3(radius/1.9f, 1, 1);
    }



    void Update()
    {
        
        Vector3 centerPosition = sphere.transform.localPosition; 
       // Debug.Log(centerPosition);
        Vector3 newLocation = player.transform.position;
       // Debug.Log(newLocation);
        float distance = Vector3.Distance(newLocation, centerPosition); 
        //Debug.Log(distance);
        player.transform.RotateAround(centerPosition,new Vector3(0,1,1), 300f * Time.deltaTime);
        
        if (distance > radius) 
        {
            Vector3 fromOriginToObject = newLocation - centerPosition; 
            fromOriginToObject *= radius / distance; 
            newLocation = centerPosition + fromOriginToObject; 
        }


    }
}


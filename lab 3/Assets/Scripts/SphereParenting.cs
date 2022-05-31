using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereParenting : MonoBehaviour
{
    public GameObject Parent;

    void Start()
    {
        var objects = GameObject.FindGameObjectsWithTag("Sphere");
        var objectCount = objects.Length;
        Debug.Log(objectCount);
        foreach (var obj in objects)
        {
            obj.transform.parent = Parent.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

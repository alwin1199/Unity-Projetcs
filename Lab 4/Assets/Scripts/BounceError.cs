using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceError : MonoBehaviour
{
    
    private GameObject bouncyObjectPrefab;
    public GameObject bouncyObject;
    // Use this for initialization
    void Start()
    {
        bouncyObject = Instantiate(bouncyObjectPrefab, new Vector3(0f, 1f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
       // GameObject bouncyObject = null;

        if (bouncyObject.transform.position.y > 0)
        {
            Vector3 newpos = bouncyObject.transform.position;
            newpos.y += 1.0f;
            bouncyObject.transform.position = newpos;
        }
        else
        {
            Vector3 newpos = bouncyObject.transform.position;
            newpos.y += 1.0f;
            bouncyObject.transform.position = newpos;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    public GameObject bouncyObjectPrefab;
    public GameObject bouncyObject;                 //
    // Use this for initialization
    void Start()
    {
        bouncyObject = Instantiate(bouncyObjectPrefab,new Vector3(0f,1f,0f),Quaternion.identity);           //
       // GameObject bouncyObject = Instantiate(bouncyObjectPrefab);
        // Debug.Log(bouncyObject.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
       
        //GameObject bouncyObject = null;                       //
        bool goingUp = true;
        //Debug.Log(bouncyObject.transform.position.y);
        
        /* if (bouncyObject.transform.position.y > 0)           //
         {
             bouncyObject.transform.position.y--;               //
         }
         else                                                   //
         {
             bouncyObject.transform.position.y++;               //
         }*/
        if (bouncyObject.transform.position.y > 3)
        {
            goingUp = false;
            Vector3 resetPos = bouncyObject.transform.position;
            resetPos.y = 1.0f;
            bouncyObject.transform.position = resetPos;
        }
        if (bouncyObject.transform.position.y < 0)
        {
            goingUp = true;
        }

        if (goingUp)
        {
            Vector3 newpos = bouncyObject.transform.position;
            newpos.y += 1.0f;
            bouncyObject.transform.position=newpos;
        }
        else
        {
            Vector3 newpos = bouncyObject.transform.position;
            newpos.y -= 1.0f;
            bouncyObject.transform.position = newpos;
        }
    }
}
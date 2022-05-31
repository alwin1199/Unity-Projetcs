using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemnet : MonoBehaviour
{
    public GameObject player;
    float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = player.transform.position;
        // Debug.Log(player.transform.position);

        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        player.transform.position = pos;
        if (pos.x < -25 || pos.z < -25 || pos.x > 25 || pos.z > 25)
        {
            player.transform.position = new Vector3(0, 1, 0);
        }
    }
}
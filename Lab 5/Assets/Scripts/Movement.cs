using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
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
        ChangeColor(pos);
    }
    void ChangeColor(Vector3 pos)
    {
        if (pos.x>0 && pos.z>0 && Input.GetKey("f"))
        {
            player.GetComponent<Renderer>().material.color = Color.green;
        }
        if (pos.x > 0 && pos.z < 0 && Input.GetKey("f"))
        {
            player.GetComponent<Renderer>().material.color = Color.red;
        }
        if (pos.x < 0 && pos.z > 0 && Input.GetKey("f"))
        {
            player.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (pos.x < 0 && pos.z < 0 && Input.GetKey("f"))
        {
            player.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (pos.x < -10 || pos.z < -10  || pos.x > 10 || pos.z > 10)
        {
            player.transform.position = new Vector3(0, 1, 0);
        }
       
    }
    
}

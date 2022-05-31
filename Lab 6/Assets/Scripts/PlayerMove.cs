using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speedMove=10f,speedLook=100f;
    float mouseX, mouseY;
    public GameObject player;
    public CharacterController controller;
    Vector3 moveDir;
    
    public Camera pov;
    // Start is called before the first frame update
    void Start()
    {
        controller = player.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        moveDir = (player.transform.forward*Input.GetAxis("Vertical"))+ (player.transform.right * Input.GetAxis("Horizontal"));
        moveDir = moveDir.normalized * speedMove;
        controller.Move(moveDir*Time.deltaTime);
        mouseX = Input.GetAxis("Mouse X")*speedLook*Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y")*speedLook*Time.deltaTime;
        pov.transform.Rotate(-mouseY, 0,0);
        player.transform.Rotate(0, mouseX, 0);
    }
    
}


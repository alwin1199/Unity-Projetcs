using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody bullet;
    public GameObject cursor;
    public LayerMask layer;
    public Transform shoot;
    Camera cam;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        ShootBall();
    }
    void ShootBall()
    {
        Ray camRay = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(camRay,out hit,100f,layer))
        {
            cursor.SetActive(true);
            cursor.transform.position = hit.point+ Vector3.up * 0.1f;
            Vector3 vo = CalculateVelocity(hit.point, shoot.position, 1f);
            transform.rotation = Quaternion.LookRotation(vo);
            
            if(Input.GetKey("f") && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                //Debug.Log("Doen");
                Rigidbody obj = Instantiate(bullet, shoot.position, Quaternion.identity);
                    obj.velocity = vo;
                
            }
        }
        else
        {
            cursor.SetActive(false);
        }
    }
    Vector3 CalculateVelocity(Vector3 target,Vector3 origin, float time)
    {
        //distance x & y
        Vector3 distance = target - origin;
        Vector3 distanceXZ = distance;
        distanceXZ.y = 0f;
        //represent distance
        float Sy = distance.y;
        float Sxz = distanceXZ.magnitude;
        //velocities
        float Vxz = Sxz / time;
        float Vy = Sy / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;
        //dis+velocity
        Vector3 result = distanceXZ.normalized;
        result *= Vxz;
        result.y = Vy;
        return result;
    }
}

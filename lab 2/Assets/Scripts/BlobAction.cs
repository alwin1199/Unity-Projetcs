using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobAction : MonoBehaviour
{
    public GameObject[] Blob=new GameObject[10];
    //private float limit[j] = 5,limit2=4,limit3=3;
    private float[] limit = new float[10];
    public int BlobNo;
    // Start is called before the first frame update
    void Start()
    {
        createBlobs(BlobNo);
    }

    // Update is called once per frame
    void Update()
    {
        for(int j=0;j<10;j++)
        {
            if (limit[j] >= -5f)
            { limit[j] = limit[j] -((j * 0.01f) + 0.2f); }
            else
                limit[j] = 5;
            Blob[j].transform.position = new Vector3(limit[j], 1f, j - 2);
        }


    }
    void createBlobs(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Blob[i] = Instantiate(Blob[i], new Vector3(5, 1, i), Quaternion.identity);
            limit[i] = i + 1 * 0.001f;
        }
    }
}

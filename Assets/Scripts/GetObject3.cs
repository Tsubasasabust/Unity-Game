using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject3 : MonoBehaviour
{
    public GameObject Cube3;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameController"))
        {
            Destroy(gameObject);
            Instantiate(Cube3, new Vector3(9.89f, -1.54f, -20.07f), new Quaternion(0f, 0f, 0f, 0f));
        }



    }
}

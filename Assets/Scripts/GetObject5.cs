using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject5 : MonoBehaviour
{
    public GameObject Sphere;
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
            Instantiate(Sphere, new Vector3(0.85f, -1.54f, -32.15f), new Quaternion(0f, 0f, 0f, 0f));
        }



    }
}

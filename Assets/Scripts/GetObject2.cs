using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject2 : MonoBehaviour
{
    public GameObject Cube2;
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
            Instantiate(Cube2, new Vector3(-2.22f, -1.54f, -19.3f), new Quaternion(0f, 0f, 0f, 0f));
        }



    }
}

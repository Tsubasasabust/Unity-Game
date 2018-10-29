using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject4 : MonoBehaviour
{
    public GameObject Cube4;
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
            Instantiate(Cube4, new Vector3(0.75f, -1.54f, -28.75f), new Quaternion(0f, 0f, 0f, 0f));
        }



    }
}

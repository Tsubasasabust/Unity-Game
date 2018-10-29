using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject : MonoBehaviour {
    public GameObject Cube1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameController"))
        {
            Destroy(gameObject);
            Instantiate(Cube1, new Vector3(6.86f, -1.54f, -17.24f), new Quaternion(0f,0f,0f,0f));
        }
      


    }
}

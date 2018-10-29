using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SphereFactory : MonoBehaviour {
    public GameObject Sphere;

    //public int flag = 1;
	// Use this for initialization
	void Start () {
        //Instantiate(Sphere, transform.position, transform.rotation);
        //InvokeRepeating();
	}

    void CrearSphere(){

    }

	// Update is called once per frame
	void Update () {

         int Sflag = 1;
  
            if (Sflag == 6){
            Instantiate(Sphere, transform.position, transform.rotation);
        }
    }
}

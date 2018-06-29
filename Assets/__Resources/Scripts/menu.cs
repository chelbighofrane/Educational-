using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void b1()
    {
        Application.LoadLevel("sc2");
    }

    public void b2()
    {
        Application.LoadLevel("sc1");
    }
}

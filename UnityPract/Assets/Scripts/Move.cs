using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour {

    public float speed = 4f;
    public NavMeshAgent nav;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void FixedUpdate () {
       
        if(Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit r;
            if(Physics.Raycast(ray, out r, 500))
            {
                nav.SetDestination(r.point);
            }
        }
	}

}

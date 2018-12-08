using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W))
        {
            animator.SetInteger("AnimState", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetInteger("AnimState", 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetInteger("AnimState", 3);
            transform.Rotate(new Vector3(0.0f, -90.0f, 0.0f));
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetInteger("AnimState", 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {   
            animator.SetInteger("AnimState", 2);
            transform.Rotate(new Vector3(0.0f, 90.0f, 0.0f));
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetInteger("AnimState", 0);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetInteger("AnimState", 4);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float speed;
    public float jumpForce;
    public float knockbackForce;

    private Rigidbody2D RB2D;

    // Use this for initialization
    private void Start ()
    {
        GetComponents();
	}

    private void GetComponents()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	private void Update ()
    {
        if (!Input.anyKey) return;
        InputControl();
	}

    private void InputControl()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void MoveForward()
    {

    }

    private void Jump()
    {
        RB2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }

    public void KnockBack()
    {
        
    }
}

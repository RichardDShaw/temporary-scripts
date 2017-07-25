using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveControl : MonoBehaviour {

    public GameObject thisPlayer;
    public Rigidbody fighter;

    public float speed=1f;
    public float rotationSpeed=60f;

    float x;
    float y;
	// Use this for initialization
	void Start () {
        y = thisPlayer.transform.eulerAngles.y;
        
	}
	
	// Update is called once per frame
	void Update () {
        y = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        thisPlayer.transform.Rotate(new Vector3(0, y, 0));
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}

﻿using UnityEngine;
using System.Collections;

public class asteroid_movement : MonoBehaviour {
    private Rigidbody2D rb2d;
    public Transform target;
    private float range;
    private float rotate;
    private float force = 200.0f;
    private Vector2 aim;
    private int timer;
    public GameObject spawner;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        range = Random.Range(-1, 1);
        rotate = Random.Range(-3, 3);
        if (rotate < 1 && rotate >= 0) {
            rotate = 1;
        }
        if (rotate >= -1 && rotate < 0) {
            rotate = -1;
        }
        

        aim = (target.position - transform.position);
        aim.x += range;
        aim.y += range;
        rb2d.AddForce(aim* force);
        timer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        //Debug.Log(aim);
        transform.Rotate(new Vector3(0, 0, rotate));
		if (transform.position.x < transform.position.x -Camera.main.orthographicSize * Camera.main.aspect*1.5 || transform.position.x > transform.position.x +Camera.main.orthographicSize * Camera.main.aspect*1.5 || transform.position.y < transform.position.y -Camera.main.orthographicSize*1.5 || transform.position.y > transform.position.y +Camera.main.orthographicSize*1.5) {
            Destroy(gameObject);
        }
    }
}

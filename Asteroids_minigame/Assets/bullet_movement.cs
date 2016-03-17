using UnityEngine;
using System.Collections;

public class bullet_movement : MonoBehaviour {
    private Rigidbody2D rb2d;
    public float maxSpeed = 10.0f;
    public GameObject spawner;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(transform.right * maxSpeed);
    }
	
	// Update is called once per frame
	void Update () {
        
        if (transform.position.x > 15 || transform.position.x < -15 || transform.position.y > 15 || transform.position.y < -15) {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Asteroid") {
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }
}

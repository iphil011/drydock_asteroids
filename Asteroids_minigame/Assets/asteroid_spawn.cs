using UnityEngine;
using System.Collections;

public class asteroid_spawn : MonoBehaviour {
    private int side;
    private int type;
    public int level;
    private int timer;
    public GameObject asteroid1;
    public GameObject asteroid2;
    public GameObject asteroid3;
    public GameObject asteroid4;
    public GameObject target;
    public GameObject Player;
    public bool debug;

   // public GameObject Shield;
    public GameObject player;
    // Use this for initialization
    void Start () {
        timer = 0;
        player = Instantiate(Player, transform.position, gameObject.GetComponent<Transform>().rotation) as GameObject;
        player.GetComponent<movement>().spawner = gameObject;
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 up = new Vector2(Random.Range(transform.position.x - 11, transform.position.x + 11), transform.position.y + 11);
        Vector2 down = new Vector2(Random.Range(transform.position.x -11, transform.position.x + 11), transform.position.y -11);
        Vector2 left = new Vector2(transform.position.x -11, Random.Range(transform.position.y -11, transform.position.y + 11));
        Vector2 right = new Vector2(transform.position.x + 11, Random.Range(transform.position.y -11, transform.position.y + 11));
        timer++;
        if (!debug)
        if (timer == 35)
        {
            timer = 0;
            side = Random.Range(0, 4);
            type = Random.Range(0, 4);
            if (type == 0)
            {
                if (side == 0)
                {
                    GameObject newAster = Instantiate(asteroid1, up, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.transform;
                    newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 1)
                {
                    GameObject newAster = Instantiate(asteroid1, down, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 2)
                {
                    GameObject newAster = Instantiate(asteroid1, left, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 3)
                {
                    GameObject newAster = Instantiate(asteroid1, right, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
            }
            if (type == 1)
            {
                if (side == 0)
                {
                    GameObject newAster = Instantiate(asteroid2, up, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 1)
                {
                    GameObject newAster = Instantiate(asteroid2, down, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 2)
                {
                    GameObject newAster = Instantiate(asteroid2, left, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 3)
                {
                    GameObject newAster = Instantiate(asteroid2, right, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;

                    }
            }
            if (type == 2)
            {
                if (side == 0)
                {
                    GameObject newAster = Instantiate(asteroid3, up, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 1)
                {
                    GameObject newAster = Instantiate(asteroid3, down, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 2)
                {
                    GameObject newAster = Instantiate(asteroid3, left, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 3)
                {
                    GameObject newAster = Instantiate(asteroid3, right, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
            }
            if (type == 3)
            {
                if (side == 0)
                {
                    GameObject newAster = Instantiate(asteroid4, up, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 1)
                {
                    GameObject newAster = Instantiate(asteroid4, down, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 2)
                {
                    GameObject newAster = Instantiate(asteroid4, left, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
                if (side == 3)
                {
                    GameObject newAster = Instantiate(asteroid4, right, transform.rotation) as GameObject;
                    newAster.GetComponent<asteroid_movement>().target = player.GetComponent<Transform>();
                        newAster.GetComponent<asteroid_movement>().spawner = gameObject;
                    }
            }
        }
	}
    void split() {

    }
}

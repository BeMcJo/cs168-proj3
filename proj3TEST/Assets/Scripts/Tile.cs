using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    protected MeshRenderer mr;
    protected BoxCollider c;
    public float respawnTimeStamp, respawnTime, floorSize;
    public bool isBreakable, active, isHole;
    public int hp;
    //public GameObject holePrefab;
    

    // Use this for initialization
    protected void Start () {
        mr = transform.GetComponent<MeshRenderer>();
        c = transform.GetComponent<BoxCollider>();
        //hole = transform.GetComponent<CircleCollider2D>();
        respawnTime = 40.0f;
        respawnTimeStamp = 0;
        floorSize = .32f;
        //print("INST");
    }

    public void SetRespawnTime()
    {
        //print("res");
        respawnTimeStamp = GameManager.time + respawnTime;
    }

    public void Break()
    {
        SetRespawnTime();
        //respawnTimeStamp = GameManager.time + respawnTime;
        
        //GameObject hole = Instantiate(holePrefab);
        //hole.transform.position = transform.position;
        //hole.transform.GetComponent<Tile>().isHole = true;
        //hole.transform.SetParent(transform);

        //hole.transform.GetComponent<Tile>().SetRespawnTime();
        //print("RESP TIMESTAP");
        //print(hole.transform.GetComponent<Tile>().respawnTimeStamp);
    }
	
	// Update is called once per frame
	protected void Update ()
    {
        active = respawnTimeStamp <= GameManager.time;
        /*if (isHole)
        {
            print("TIME");
            print(GameManager.time);
            print("STAMP");
            print(respawnTimeStamp);
            print(active);
            if (active)
            {
                print(1);
                Destroy(gameObject);
            }
        }
        else
        {*/
        mr.enabled = active;
        c.enabled = active;
        //}
        if (active && !isHole)
        {
            if (transform.childCount > 0)
            {
                Destroy(transform.GetChild(0).gameObject);
            }
        //    c2D.size = new Vector3(floorSize, floorSize, 0);
        }
        //else
        // {
        //    c2D.size = new Vector3(holeSize, holeSize, 0);
        //}
        //hole.enabled = !active;

    }
}

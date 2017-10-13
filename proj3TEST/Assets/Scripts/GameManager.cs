using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameManager gameManager;
    public static float time;
	// Use this for initialization
	void Start () {
        if (gameManager == null)
            gameManager = this;
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        time += .1f;
	}
}

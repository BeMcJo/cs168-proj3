using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    public static Map mapManager;
    int[] mapLayout;    // Each element consists of what the tile for the terrain will be, -1 == empty
    //ArrayList respawnTiles = new ArrayList();   // Tiles to respawn 
    public GameObject[] tilePrefabs;
    int dim;
    // Use this for initialization
   
    void Start () {
        if (!mapManager)
            mapManager = this;
        dim = 100;
        mapLayout = new int[dim * dim];
        for(int i = 0; i < dim * dim; i++)
        {
            mapLayout[i] = 0;
        }
      

        for (int i = 0; i < dim; i++)
        {
            for(int j = 0; j < dim; j++)
            {
                int k;
                if (i > dim / 2)
                    k = 0;
                else
                    k = 1;
                
                GameObject tile = Instantiate(tilePrefabs[k]);
                tile.transform.SetParent(transform);
                tile.transform.position = new Vector3(j*.5f, 0, i * .5f);
                //RectTransform rt = tile.transform.GetComponent<RectTransform>();
                //tile.transform.position = new Vector3(rt.rect.width * j * 5 - translateX, rt.rect.height * i * 5 - translateY, 0);// - new Vector3(translateX,translateY,0);
            }
        }
      
    }

    public bool onFloor(Player p)
    {
        
        return true;
    }
	
	// Update is called once per frame
	void Update ()
    {
       // print(transform.GetChild(0).transform.localPosition.x);
       // print(transform.GetChild(0).transform.localPosition.y);
    }
}

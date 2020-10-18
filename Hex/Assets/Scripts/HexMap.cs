using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
        
    }

    public GameObject HexPreFab;

    public Material[] HexMaterials;

    int mapHeight = 7;
    int mapWidth = 10;

    public void GenerateMap(){

        for(int column = 0; column < mapWidth; column++){
            for(int row = 0; row < mapHeight; row++){

                //Instatiate a Hex
                Hex h = new Hex(column, row);
                
                GameObject HexGo = (GameObject)Instantiate(HexPreFab, 
                            h.Position(),
                            Quaternion.identity, 
                            this.transform
                            );

                HexGo.GetComponentInChildren<TextMesh>().text = string.Format("{0},{1}", column, row);      

                MeshRenderer mr = HexGo.GetComponentInChildren<MeshRenderer>();
                mr.material = HexMaterials[Random.Range(0, HexMaterials.Length)];
            }
        }
    }
}

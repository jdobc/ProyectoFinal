using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObjetos : MonoBehaviour
{
    public GameObject objetoExplode;
    public GameObject objetoNormal;
    public GameObject objetoNormal2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            SpawnObjetoExplode();
        }
        if(Input.GetKeyDown("l")){
            GameObject noexplodeObjeto = Instantiate(objetoNormal2) as GameObject;
        }
    }

    public void SpawnObjetoExplode(){
        Destroy(objetoNormal);
        GameObject explodeObjeto = Instantiate(objetoExplode) as GameObject;
        explodeObjeto.GetComponent<explode>().Explode();
    }
}


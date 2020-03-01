using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    public GameObject explosion;
    public Vector3 efectoExplosion;
    public float destroyDelay;
    public float minforce;
    public float maxforce;
    public float radius;
    // Start is called before the first frame update
     public void Explode(){
         if(explosion != null){
             GameObject explosionFX = Instantiate (explosion,transform.position + efectoExplosion,Quaternion.identity) as GameObject;
             Destroy(explosionFX,20);
         }
         
         foreach(Transform t in transform){
             var rb = t.GetComponent<Rigidbody>();
             if(rb != null){
                 rb.AddExplosionForce (Random.Range(minforce,maxforce),transform.position, radius);
             }
        
         
         Destroy (t.gameObject,destroyDelay);
         }

     }
    void Start()
    {
        Explode();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

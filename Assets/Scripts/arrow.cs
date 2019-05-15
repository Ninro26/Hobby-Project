using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {

    public float speed = 20;
    public Rigidbody2D rb;
    public float distance;
    public LayerMask whatIsSolid;
	// Use this for initialization
	void Start () {


        
    }
    private void Update()
    {
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitinfo.collider != null)
        {
            if (hitinfo.collider.CompareTag("Enemy"))
            {
                //Enemy damage
            }
            DestroyProjectile();

        }


        transform.Translate(transform.up * speed * Time.deltaTime);


    }

     void DestroyProjectile()
    {

        Destroy(gameObject);
    }




}



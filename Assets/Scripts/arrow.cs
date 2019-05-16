using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour {

    public float speed = 20;
    public Rigidbody2D rb;
    public float distance;
    public LayerMask whatIsSolid;
	// Use this for initialization
	void start () {

     

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
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        rb.AddForceAtPosition(rb.velocity * -1, transform.TransformPoint(0, -25, 0));

    }


    void DestroyProjectile()
    {

        Destroy(gameObject);
    }




}



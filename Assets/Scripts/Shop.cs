using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {


    SpriteRenderer spriteRenderer;


    // Use this for initialization
    void Start () {

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

     public void change(Sprite differentSprite)
    {

        spriteRenderer.sprite = differentSprite;

    }

}

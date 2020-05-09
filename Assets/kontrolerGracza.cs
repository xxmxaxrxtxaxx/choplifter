using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class kontrolerGracza : MonoBehaviour
{

    public Rigidbody2D helikopter;
    public SpriteRenderer sprite;
    public int przyspiesznie;
	public GameObject bomba;
	public Transform helikopter_pozycja;
    public float maxSpeed=4;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ograniczPrzyspieszenieHelikoptera();
        obrocHelikopter();

        if (Input.GetKey("w"))
        {
            helikopter.AddForce(new Vector2(0f, 1f)* przyspiesznie);
        }
        if (Input.GetKey("s"))
        {
            helikopter.AddForce(new Vector2(0f, -1f) * przyspiesznie);
        }
        if (Input.GetKey("a"))
        {
            helikopter.AddForce(new Vector2(-1f, 0f) * przyspiesznie);   
            sprite.flipX = false;
        }
        if (Input.GetKey("d"))
        {
            helikopter.AddForce(new Vector2(1f, 0f) * przyspiesznie);
            sprite.flipX = true;
        }
		if(Input.GetKeyDown("q"))
		{
			Instantiate(bomba, new Vector3(helikopter_pozycja.position.x, helikopter_pozycja.position.y-1, helikopter_pozycja.position.z), transform.rotation);
        }
       
        
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "strzal")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 1f);
            Application.LoadLevel(0);
        }
    }

    void ograniczPrzyspieszenieHelikoptera()
    {
        helikopter.velocity = new Vector2(Mathf.Clamp(helikopter.velocity.x, -maxSpeed, maxSpeed), Mathf.Clamp(helikopter.velocity.y, -maxSpeed, maxSpeed));
    }
    void obrocHelikopter()
    {
        helikopter.rotation = 0;
    }
    

}

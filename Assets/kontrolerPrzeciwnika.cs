using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.UIElements;
using UnityEngine;

public class kontrolerPrzeciwnika : MonoBehaviour
{
    Rigidbody2D pozycja;
    public GameObject strzalc;
    public Rigidbody2D czolg;
    bool pomocnicza = true;


    private void Start()
    {
        pozycja = GetComponent<Rigidbody2D>();
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "bomba")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(this);
        }
    }
    private void Update()
    {
        zablokujObrot();
        if (pomocnicza) 
        { 
            
            GameObject strzal = Instantiate(strzalc, new Vector3(pozycja.position.x - 1, pozycja.transform.position.y + 1, pozycja.transform.position.z), transform.rotation);
            strzal.GetComponent<Rigidbody2D>();
            Rigidbody2D x = strzal.GetComponent<Rigidbody2D>();
            x.AddForce(new Vector2(-5f, 5f) * 100);
            pomocnicza = false;
            StartCoroutine(odliczaj());
        }
        
    }

    IEnumerator odliczaj()
    {
        yield return new WaitForSeconds(2);
       pomocnicza = true;
    }
    void zablokujObrot()
    {
        czolg.rotation = 0;
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usuniecieBomby : MonoBehaviour
{
    public float Czas = 1f;
    // Start is called before the first frame update
    void Start()
    {
 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "sciana")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject);
        }
    }
}

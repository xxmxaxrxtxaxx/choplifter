using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ruchKamery : MonoBehaviour
{
    public Transform gracz;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(gracz.position.x, transform.position.y, transform.position.z);
    }
}

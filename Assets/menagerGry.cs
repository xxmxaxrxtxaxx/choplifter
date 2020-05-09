using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menagerGry : MonoBehaviour
{
    public GameObject czolg;
    public Transform helikopter_pozycja;
    public Transform czolg_pozycja;
    public GameObject strzalc;

    float losowaPozycjaX;
    float pozycjaY=-4;
    float pozycjaZ = 0;

    int iloscCzolgow;
    bool pomocnicza = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(iloscCzolgow<10 && pomocnicza)
        {
             
            dodajPrzeciwnika();
            pomocnicza = false;
            StartCoroutine(odliczaj());
        }
    }

    void dodajPrzeciwnika()
    {
        losowaPozycjaX = Random.Range(-120, 10);
        Instantiate(czolg, new Vector3(losowaPozycjaX, pozycjaY, pozycjaZ), transform.rotation);
        iloscCzolgow++;
    }
    IEnumerator odliczaj()
    {
        yield return new WaitForSeconds(5);
        pomocnicza = true;
    }
   


}

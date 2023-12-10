using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereHareket : MonoBehaviour
{
    GameObject ninja, siradan;
    private Transform oyuncu,adam;
    private Vector3 kamerGeciciKonum;
    // Start is called before the first frame update
    void Start()
    {
        oyuncu = GameObject.FindWithTag("oyuncu").transform;
        adam = GameObject.FindWithTag("siradan").transform;

        ninja = GameObject.FindWithTag("oyuncu");
        siradan = GameObject.FindWithTag("siradan");

    }

    // Update is called once per frame
    void Update()
    {
        if (ninja.GetComponent<Move>().git) {
            kamerGeciciKonum = transform.position;
            kamerGeciciKonum.x = oyuncu.position.x;
            transform.position = kamerGeciciKonum;

        }
        if (siradan.GetComponent<MoveSiradanAdam>().move) {
            kamerGeciciKonum = transform.position;
            kamerGeciciKonum.x = adam.position.x;
            transform.position = kamerGeciciKonum;
        }
      

        if (Input.GetKeyDown(KeyCode.N)) {
            ninja.GetComponent<Move>().git = true;
            siradan.GetComponent<MoveSiradanAdam>().move = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            siradan.GetComponent<MoveSiradanAdam>().move = true;
            ninja.GetComponent<Move>().git = false;
        }
    }
}

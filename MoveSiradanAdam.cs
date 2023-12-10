using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSiradanAdam : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private SpriteRenderer spr;
    float hiz = 4;
    public bool move = false;
    [SerializeField]
    Rigidbody2D nb;
    [SerializeField]
    public float zipla = 5f;

    [SerializeField]
    private GameObject[] zombs;
    
  
    void Start()
    {
        for(int x = 0; x < 10; x++)
        {
            Instantiate(zombs[Random.Range(0, 4)], new Vector3(Random.Range(-53, 26), Random.Range(5, 15), 0f), Quaternion.identity);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (move) {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            if (x > 0 && spr.flipX)
            {
                spr.flipX = false;
            }
            if (x < 0 && !spr.flipX)
            {
                spr.flipX = true;
            }
            transform.position += new Vector3(x, 0f, 0f) * hiz * Time.deltaTime;
            if (Input.GetButton("Jump"))
            {
                nb.AddForce(new Vector2(0f, zipla), ForceMode2D.Impulse);
            }
        }
      

        
    }
    private void OnMouseDown()
    {
        move = true;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.tag=="dusman") {
            Debug.Log("Dusman a Carptim");
            Destroy(collision.gameObject);
        }
    }
}

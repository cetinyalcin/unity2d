using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private SpriteRenderer spr;
    float hiz = 4;
    public bool git=false;
    [SerializeField]
     Rigidbody2D nb;
    [SerializeField]
    public float zipla = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (git) {
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
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                nb.AddForce(new Vector2(0f, zipla), ForceMode2D.Impulse);
            }
        }

       
        
    }
    private void OnMouseDown()
    {
        git = true;
    }
}

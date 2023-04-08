using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform GroundCheck;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }else if(Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    rb.AddForce(Vector3.up * 10, ForceMode2D.Impulse);
        //}

        transform.position = pos;
    }
}

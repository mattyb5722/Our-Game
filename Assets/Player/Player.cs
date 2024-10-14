using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{

    public float speedMult = 0.01f;
    public List<Component> weapons = new List<Component>();

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    private void FixedUpdate()
    {

        Vector2 position = transform.position;
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        position.x = position.x + (speedMult * HorizontalInput);
        position.y = position.y + (speedMult * VerticalInput);
        transform.position = position;

               
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{

    public float speedMult = 0.01f;
    public List<Component> weapons = new List<Component>();
    public float health = 100;

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

    private void OnTriggerEnter2D(Collider2D collider)
    {
        print(collider.gameObject.name);
    }

    public void HitPlayer(float damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            print("Dead");
        }
    }
}

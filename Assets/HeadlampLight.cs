using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class HeadlampLight : MonoBehaviour
{
    private GameObject sprite;
    public GameObject lamp;
    private int counter;
    public float attackSpeed = 200f;
    public float durration = 1f;
    public float transparency = 0.5f;
    public float heightOffest = 1.65f;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GameObject.FindGameObjectWithTag("Sprite");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;

        if (counter == attackSpeed)
        {
            GameObject newLight = GameObject.Instantiate(lamp);
            SpriteRenderer s = newLight.GetComponent<SpriteRenderer>();
            s.color = new Color(1f,1f, 0f, transparency);
            PolygonCollider2D c = newLight.GetComponent<PolygonCollider2D>();
            newLight.transform.position = sprite.transform.position + (sprite.transform.up * heightOffest);
            newLight.transform.rotation = sprite.transform.rotation;
            newLight.transform.SetParent(sprite.transform);
            newLight.SetActive(true);

            Destroy(newLight, durration);

            counter = 0;
        }



    }
}

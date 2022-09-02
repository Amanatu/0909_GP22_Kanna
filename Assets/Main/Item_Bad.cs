using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Bad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (pos.y <= -10)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

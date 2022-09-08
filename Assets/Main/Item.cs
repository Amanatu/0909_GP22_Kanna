using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // ê∂ê¨Ç∆çÌèú
    void Update()
    {
        Vector2 pos = transform.position;
        if(pos.y <= -10)
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_ob_l : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // �����A�ړ��ƍ폜
    void Update()
    {
        transform.Translate(0.045f, 0, 0);
        Vector2 pos = transform.position;
        if (pos.x >= 10)
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

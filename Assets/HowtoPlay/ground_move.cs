using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (pos.x >= 0.06)
        {
            transform.Translate(-0.02f, 0, 0);
        }
        else if (pos.x <= 0.05)
        {
            transform.Translate(0.02f, 0, 0);
        }
    }
}

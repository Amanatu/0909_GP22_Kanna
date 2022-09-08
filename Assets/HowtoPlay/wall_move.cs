using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (pos.y >= -0.26f)
        {
            transform.Translate(0, -0.02f, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    public float time_max = 60.0f;
    public static float time_now = 0;
    // Start is called before the first frame update
    void Start()
    {
        time_now = time_max;
    }

    // Update is called once per frame
    void Update()
    {
        time_now -= Time.deltaTime;

        if(time_now <= 0)
        {
            time_now = time_max;
        }
    }
}

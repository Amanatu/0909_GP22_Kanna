using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trap : MonoBehaviour
{
    [SerializeField]
    GameObject[] traps;
    
    public Sprite image_R;
    public Sprite image_L;
    public Image trap_r;
    public Image trap_l;

    [SerializeField]
    float trap_time = 5;

    int select = 0;
    bool choice = true;

    // Start is called before the first frame update
    void Start()
    {
        trap_r = GameObject.Find("R").GetComponent<Image>();
        trap_l = GameObject.Find("L").GetComponent<Image>();
        trap_r.enabled = false;
        trap_l.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        trap_time -= Time.deltaTime;
        if(trap_time <= 0)
        {
            if (choice == true)
            {
                select = Random.Range(0, 100);
                choice = false;
            }
            if(select >= 50)
            {
                trap_r.enabled = true;
                if(trap_time <= -1)
                {
                    trap_r.enabled = false;
                    Instantiate(traps[0]);
                    trap_time = 5;
                    choice = true;
                }
            }
            else
            {
                trap_l.enabled = true;
                if (trap_time <= -1)
                {
                    trap_l.enabled = false;
                    Instantiate(traps[1]);
                    trap_time = 5;
                    choice = true;
                }
            }
        }
    }
}

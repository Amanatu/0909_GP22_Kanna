using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_point : MonoBehaviour
{
    [SerializeField]
    GameObject life_ob;
    // ライフポイントを表すオブジェクトの生成
    void Start()
    {
        for (int i = 0; i < PL.life_point; i++)
        {
          GameObject life_obj = Instantiate(life_ob, new Vector3(8.5f, 3.7f - (0.7f * i), 0), Quaternion.identity);
            life_obj.name = "HP" + i;
        }
    }

    void Update()
    {
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_point : MonoBehaviour
{
    [SerializeField]
    GameObject life_ob;
    // ���C�t�|�C���g��\���I�u�W�F�N�g�̐����ƍ폜
    void Start()
    {
        for (int i = 0; i < PL.life_point; i++)
        {
          GameObject life_obj = Instantiate(life_ob, new Vector3(8.5f, 3.7f - (0.7f * i), 0), Quaternion.identity);
            life_obj.name = "HP" + i;
        }
    }
    //�o�����PL��LIFE�ƘA����������
    // Update is called once per frame
    void Update()
    {
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    public float time_max = 60.0f; //���Ԑ���
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

        //�f�o�b�N�p����Clear
        if (Input.GetKey(KeyCode.Return))
        {
            time_now = 0;
            PL.life_point = 4;
        }

        //Clear
        if(time_now <= 0)
        {
            SceneManager.LoadScene("GameClear");
            time_now = time_max;
            PL.life_point = 4;
        }

        //�Q�[���I�[�o�[
        if(PL.life_point <= 0)
        {
            SceneManager.LoadScene("GameOver");
            PL.life_point = 4;
        }
    }
}

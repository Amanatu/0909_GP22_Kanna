using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL : MonoBehaviour
{
    [SerializeField]
    public float speed = 10; //移動速度
    [SerializeField]
    public float jump = 10; //ジャンプ
    //重力
    Rigidbody2D rb_pl;
    private bool is_ground;　//地面判定

    [SerializeField]
    public static int score = 0;

    void Start()
    {
        //rbの取得
        rb_pl = GetComponent<Rigidbody2D>();
        score = 0;
    }

    void Update()
    {
        //右移動 右とD
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
        //左移動　左とA
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
        //ジャンプは地面にいるときだけ
        if (Input.GetKeyDown(KeyCode.Space) && is_ground)
        {
            rb_pl.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

    }

    //地面との接触判定によるbool
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "ground") 
        {
            is_ground = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "ground")
        {
            is_ground = false;
        }
    }
}

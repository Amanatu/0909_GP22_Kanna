using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL : MonoBehaviour
{
    //基本動作
    [SerializeField]
    public float speed = 10; //移動速度
    [SerializeField]
    public float jump = 10; //ジャンプ
    //重力
    Rigidbody2D rb_pl;
    private bool is_ground;　//地面判定

    //スコアとライフ
    [SerializeField]
    public static int score = 0;
    [SerializeField]
    public static int life_point = 4;

    //音楽
    public AudioClip se_bad;
    public AudioClip se_get;

    AudioSource audioSource;

    //ライフオブジェクト
    GameObject[] tagobjs;
    void Start()
    {
        //rbの取得
        rb_pl = GetComponent<Rigidbody2D>();
        score = 0;
        audioSource = GetComponent<AudioSource>();

        tagobjs = GameObject.FindGameObjectsWithTag("HP");
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

    //マイナスアイテムにあったった
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bad_item")
        {
            audioSource.PlayOneShot(se_bad);
            life_point -= 1;
            var hog = tagobjs[life_point];
            Destroy(hog);
        }
        //アイテムにあたった
        if (collision.tag == "plus_item")
        {
            audioSource.PlayOneShot(se_get);
            PL.score += 1;
        }
    }
}

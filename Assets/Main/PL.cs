using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL : MonoBehaviour
{
    //��{����
    [SerializeField]
    public float speed = 10; //�ړ����x
    [SerializeField]
    public float jump = 10; //�W�����v
    //�d��
    Rigidbody2D rb_pl;
    private bool is_ground;�@//�n�ʔ���

    //�X�R�A�ƃ��C�t
    [SerializeField]
    public static int score = 0;
    [SerializeField]
    public static int life_point = 4;

    //���y
    public AudioClip se_bad;
    public AudioClip se_get;

    AudioSource audioSource;

    //���C�t�I�u�W�F�N�g
    GameObject[] tagobjs;
    void Start()
    {
        //rb�̎擾
        rb_pl = GetComponent<Rigidbody2D>();
        score = 0;
        audioSource = GetComponent<AudioSource>();

        tagobjs = GameObject.FindGameObjectsWithTag("HP");
    }

    void Update()
    {
        //�E�ړ� �E��D
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
        //���ړ��@����A
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
        //�W�����v�͒n�ʂɂ���Ƃ�����
        if (Input.GetKeyDown(KeyCode.Space) && is_ground)
        {
            rb_pl.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

    }

    //�n�ʂƂ̐ڐG����ɂ��bool
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

    //�}�C�i�X�A�C�e���ɂ���������
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bad_item")
        {
            audioSource.PlayOneShot(se_bad);
            life_point -= 1;
            var hog = tagobjs[life_point];
            Destroy(hog);
        }
        //�A�C�e���ɂ�������
        if (collision.tag == "plus_item")
        {
            audioSource.PlayOneShot(se_get);
            PL.score += 1;
        }
    }
}

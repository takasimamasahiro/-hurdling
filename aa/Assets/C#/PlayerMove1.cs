using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class PlayerMove1 : Goal
{
    //左右のいどうの力
    [SerializeField] private float m_movePower;
    //リジッドボディ
    Rigidbody2D m_rb = default;
    //外でジャンプの力を決められる
    [SerializeField] private float m_jumpPower;
    //ジャンプのカウント
    int _count = 0;
    //プレイ時間の表示をする
    Text _timeText = default;
    float _timer;
    //反転
    float m_scaleX;
    SpriteRenderer _sp;

    bool _timesStop = false;

    public AudioClip se;
    AudioSource _jumpsound;


    //public class Count : MonoBehaviour
    //{
    //public Text Scoretext;
    //public static int score = 0;
    //}


    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        _sp = GetComponent<SpriteRenderer>();
        //フレームレートの設定
        Application.targetFrameRate = 100;
        _timeText = GameObject.Find("Time").GetComponent<Text>();
        _jumpsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    void Update()
    {

        if (!_timesStop)
        {
            _timer += Time.deltaTime;
            _timeText.text = _timer.ToString("F2");
            //string aa = _timeText.GetComponent<Text>().text;
            ScoreManager.Scoreb = (int)_timer;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (_count < 1 )
            {
                Debug.Log("ikeru");
                m_rb.AddForce(Vector2.up * m_jumpPower, ForceMode2D.Impulse);
                _jumpsound.Play();
            }
            //_count++;
        }
        if (Input.GetKey(KeyCode.L))
        {
            Debug.Log("aaaa");
            this.gameObject.transform.position = new Vector3(gameObject.transform.position.x, 5);
        }
        float h = Input.GetAxisRaw("Horizontal");
        m_rb.velocity = new Vector2(h * m_movePower, m_rb.velocity.y);
        FlipX(h);

        //m_rb.AddForce(Vector2.right * h * m_movePower, ForceMode2D.Force);
        //  if(m_movePower < )
        //{
        //m_rb.AddForce(Vector2.right * h * m_movePower, ForceMode2D.Force);
        //}


        
        //if (Input.GetKey(KeyCode.D))
        //{
        //    Debug.Log("d");
        //    m_rb.AddForce(Vector2.right * m_movePower, ForceMode2D.Force);
        //    FlipX(m_movePower);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    Debug.Log("a");
        //    m_rb.AddForce(Vector2.left * m_movePower, ForceMode2D.Force);

        //}
        //if (m_flipX)
        //{
        //    FlipX(m_h);
        //}

    }

    void FlipX(float horizontal)
    {
        m_scaleX = this.transform.localScale.x;

        if (horizontal <= -1)
        {
            _sp.flipX = true;
        }
        else if (horizontal <= 1)
        {
            _sp.flipX = false;
        }
    }
    //private void OnCollision(Collider2D collision)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("yibareta");
            _count = 0;
        }
        if (collision.gameObject.tag == "Goll")
        {
            //ゴールにぶつかったらプレイ時間を止める
            _timesStop = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _count++;
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] ParticleSystem _dust;
    [SerializeField] float _speed;
    Rigidbody2D _rigid;
    bool _isRight = true;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        bool isFlip = false;
        float x = Input.GetAxisRaw("Horizontal") * _speed;

        if (_rigid.velocity.x > 0f && x < 0f)
        {
            if (_isRight == true)
            {
                _isRight = false;
                isFlip = true;
            }
        }
        else if (_rigid.velocity.x < 0f && x > 0f)
        {
            if (_isRight == false)
            {
                _isRight = true;
                isFlip = true;
            }
        }
        else if (_rigid.velocity.x == 0f && x > 0f)
        {
            if (_isRight == false)
            {
                _isRight = true;
                isFlip = true;
            }
        }
        else if (_rigid.velocity.x == 0f && x < 0f)
        {
            if (_isRight == true)
            {
                _isRight = false;
                isFlip = true;
            }
        }

        _rigid.AddForce(Vector2.right * x);

        if (isFlip == true)
            Flip();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            CreateDust();
        }
    }

    void Flip()
    {
        transform.Rotate(new Vector3(0, 180, 0));
        CreateDust();
    }

    void CreateDust()
    {
        _dust.Play();
    }
}

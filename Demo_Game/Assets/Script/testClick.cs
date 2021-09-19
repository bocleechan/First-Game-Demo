using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class testClick : MonoBehaviour
{
    public static bool isGameOver = false;
    private Rigidbody2D Rigidbody2D;
    private Animator ani;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        isGameOver = false;
        ani = GetComponent<Animator>();
        
        Rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ani.SetBool("acttack", true);
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            ani.SetBool("acttack", false);
            
        }

        if (!isGameOver)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                ani.SetBool("run", true);
                ani.SetBool("ilde", false);
                if (gameObject.transform.localScale.x > 0)
                {
                    gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1,
                        gameObject.transform.localScale.y, gameObject.transform.localScale.z);
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                ani.SetBool("run", true);
                ani.SetBool("ilde", false);
                if (gameObject.transform.localScale.x < 0)
                {
                    gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1,
                        gameObject.transform.localScale.y, gameObject.transform.localScale.z);
                }
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                ani.SetBool("run", true);
                ani.SetBool("ilde", false);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
                ani.SetBool("run", true);
                ani.SetBool("ilde", false);
            }
            else
            {
                ani.SetBool("run", false);
                ani.SetBool("ilde", true);
            }
        }
    }
}

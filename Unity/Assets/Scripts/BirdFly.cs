using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1; //Скорость
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Условие нажатия на мышку
        {
            //jump
            rb.velocity = Vector2.up * velocity; // Задаем движение нашей птичке
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //Вызывается при возникновении соприкосновения с другими колайдерами
    {
        gameManager.GameOver();
    }
}

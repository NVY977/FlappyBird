using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Работа со сценами

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    void Start()
    {
        Time.timeScale = 1;
    }

 
    public void GameOver()
    {
        gameOverCanvas.SetActive(true); //Как только птичка соприкасается с чем-то она умирает
        Time.timeScale = 0; // И изначальное значение становится равно 0
    }
    public void Replay() // Перезапуск уровня при смерти
    {
        SceneManager.LoadScene(0);
    }
}

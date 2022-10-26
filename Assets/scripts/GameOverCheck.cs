using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCheck : MonoBehaviour
    
    
{
    [SerializeField]
    private GameObject GameOverUI;

    private void Awake()
    {
        GameOverUI.SetActive(false); // 게임 시작 되었을 때 초기화 시켜주면서 게임 오버 되었음을 꺼준다.
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gameObject = collision.gameObject;
        if( gameObject.CompareTag("Hurdle"))
        {
            Time.timeScale = 0f; // 시간을 0 으로 지정해줌으로써 게임은 멈춘다.
            GameOverUI.SetActive(true); // 게임 오버 발동
        }
    }

    public static void ReStart()
    {
        Time.timeScale = 1f; // 시간을 1 으로 지정해줌으로써 게임은 다시 진행된다.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

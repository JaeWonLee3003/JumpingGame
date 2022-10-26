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
        GameOverUI.SetActive(false); // ���� ���� �Ǿ��� �� �ʱ�ȭ �����ָ鼭 ���� ���� �Ǿ����� ���ش�.
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gameObject = collision.gameObject;
        if( gameObject.CompareTag("Hurdle"))
        {
            Time.timeScale = 0f; // �ð��� 0 ���� �����������ν� ������ �����.
            GameOverUI.SetActive(true); // ���� ���� �ߵ�
        }
    }

    public static void ReStart()
    {
        Time.timeScale = 1f; // �ð��� 1 ���� �����������ν� ������ �ٽ� ����ȴ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

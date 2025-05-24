using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager i;

    [SerializeField]int score;
    Text scoreText;             //���ھ� Text ������Ʈ�� ��Ƶ� ����

    private void Awake()
    {
        i = this;       //���� �Ŵ��� �ڽ��� i ������ ����

    }

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }
    public void AddScore()
    {
        score++;    //��������
        scoreText.text = "SCORE:" + score; //���� �ؽ��z ���� 
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}

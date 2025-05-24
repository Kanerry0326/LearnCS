using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager i;

    [SerializeField]int score;
    Text scoreText;             //스코어 Text 컴포넌트를 담아둘 변수

    private void Awake()
    {
        i = this;       //게임 매니저 자신을 i 변수에 참조

    }

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }
    public void AddScore()
    {
        score++;    //점수증가
        scoreText.text = "SCORE:" + score; //점수 텍스틑 갱신 
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}

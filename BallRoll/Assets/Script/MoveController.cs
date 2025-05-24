using UnityEngine;

public class MoveController : MonoBehaviour
{
    //상태, 멤버 필드,
    //SerializeField 접근 제한자에 상관없이 에디터에 변수가 노출됨
    Rigidbody rb;        //리지드바디 컴포넌트를 담아둘 변수, 참조, 연결
    [SerializeField] float speed = 5f;   //공 속도

    //기능
    //멤버 메소드

    //플레이 버튼 누르면 가장 먼저 호출
    private void Awake()
    {
        //Debug.Log("어웨이크 호출");
    }
    
    //어웨이크 다음 호출!!
    //게임 오브젝트가 비활성화 상태에서 활성화 될 때마다 호출됨.
    private void OnEnable()
    {
        //Debug.Log("이네이블 호출");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("반가워 유니티!!");
        
        //만약 rb 변수가 null 상태라면 비어있는 상태라면
        if (rb == null) rb = GetComponent<Rigidbody>();
        //같은 오브젝트의 컴포넌트들 중 Rigidbody 컴포넌트가 있다면 참조, 연결,
    }
    private void FixedUpdate()
    {
        //Debug.Log("픽스드 업데이트 호출");
        
        float x = Input.GetAxis("Horizontal");
        //Input.GetAxis("Horizontal") 방향키 <- -> 또는 A D
        //왼쪽은 -1, 오른쪽 1, 입력이 없다면 0
        //만약 A를 눌렀다면 0 ~ -1 점차적으로 변환

        float z = Input.GetAxis("Vertical");

        //Debug.Log("x:" + x);
        //Debug.Log("z:" + z);

        Vector3 force = new Vector3(x, 0, z);
        rb.AddForce(force * speed);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("업데이트 호출");
    }

    private void LateUpdate()
    {
        //Debug.Log("레이트 업데이트 호출");
    }

    private void OnDisable()
    {
        //Debug.Log("온디서블 호출");
    }

    private void OnDestroy()
    {
        //Debug.Log("온디스트로이 호출");
    }
}

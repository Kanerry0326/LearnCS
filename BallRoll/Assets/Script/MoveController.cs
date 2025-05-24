using UnityEngine;

public class MoveController : MonoBehaviour
{
    //����, ��� �ʵ�,
    //SerializeField ���� �����ڿ� ������� �����Ϳ� ������ �����
    Rigidbody rb;        //������ٵ� ������Ʈ�� ��Ƶ� ����, ����, ����
    [SerializeField] float speed = 5f;   //�� �ӵ�

    //���
    //��� �޼ҵ�

    //�÷��� ��ư ������ ���� ���� ȣ��
    private void Awake()
    {
        //Debug.Log("�����ũ ȣ��");
    }
    
    //�����ũ ���� ȣ��!!
    //���� ������Ʈ�� ��Ȱ��ȭ ���¿��� Ȱ��ȭ �� ������ ȣ���.
    private void OnEnable()
    {
        //Debug.Log("�̳��̺� ȣ��");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("�ݰ��� ����Ƽ!!");
        
        //���� rb ������ null ���¶�� ����ִ� ���¶��
        if (rb == null) rb = GetComponent<Rigidbody>();
        //���� ������Ʈ�� ������Ʈ�� �� Rigidbody ������Ʈ�� �ִٸ� ����, ����,
    }
    private void FixedUpdate()
    {
        //Debug.Log("�Ƚ��� ������Ʈ ȣ��");
        
        float x = Input.GetAxis("Horizontal");
        //Input.GetAxis("Horizontal") ����Ű <- -> �Ǵ� A D
        //������ -1, ������ 1, �Է��� ���ٸ� 0
        //���� A�� �����ٸ� 0 ~ -1 ���������� ��ȯ

        float z = Input.GetAxis("Vertical");

        //Debug.Log("x:" + x);
        //Debug.Log("z:" + z);

        Vector3 force = new Vector3(x, 0, z);
        rb.AddForce(force * speed);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("������Ʈ ȣ��");
    }

    private void LateUpdate()
    {
        //Debug.Log("����Ʈ ������Ʈ ȣ��");
    }

    private void OnDisable()
    {
        //Debug.Log("�µ𼭺� ȣ��");
    }

    private void OnDestroy()
    {
        //Debug.Log("�µ�Ʈ���� ȣ��");
    }
}

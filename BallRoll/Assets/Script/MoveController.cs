using UnityEngine;

public class MoveController : MonoBehaviour
{
    //����, ��� �ʵ�,
    Rigidbody rb;
    [SerializeField] float speed = 5f;

    //���

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("�ݰ��� ����Ƽ!!");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0, z);
        rb.AddForce(move * speed);
    }
}

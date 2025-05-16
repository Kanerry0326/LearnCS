using UnityEngine;

public class MoveController : MonoBehaviour
{
    //상태, 멤버 필드,
    Rigidbody rb;
    [SerializeField] float speed = 5f;

    //기능

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("반가워 유니티!!");
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

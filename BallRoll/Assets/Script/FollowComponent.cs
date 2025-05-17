using UnityEngine;

public class FollowComponent : MonoBehaviour
{
    Transform ballTrans;        //�� ������Ʈ�� TransForm ������Ʈ�� ��Ƶ� ����.
    Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballTrans = GameObject.Find("Ball").GetComponent<Transform>();
        //���̾��Ű�� �ִ� ������Ʈ �� Ball �̶�� �̸��� ������Ʈ�� ã�Ƽ� 
        //���� �ִٸ� �ش� ������Ʈ�� ������Ʈ �� Transform ������Ʈ��
        //ballTrans������ ����, ����.

        offset = transform.position - ballTrans.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        //Debug.Log(ballTrans.position);
        //ī�޶��� ��ġ�� ���� ��ġ�� ����
        transform.position = ballTrans.position + offset;
    }
}

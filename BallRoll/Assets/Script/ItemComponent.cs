using UnityEngine;

public class ItemComponent : MonoBehaviour
{
    //�浹 ����
    //�浹�ϴ� �� ������Ʈ �� �ݶ��̴� ������Ʈ�� ���ԵǾ��־�� ��
    //�浹�ϴ� �� ������Ʈ �� �� ������Ʈ�� RigidBody ������Ʈ�� ���ԵǾ��־�� ��.

    //�ݶ��̴��� isTrigger �ɼ��� ��Ȱ��ȭ �� ��� ȣ��

    //���� �浹 �� �� �� ȣ��
    private void OnCollisionEnter(Collision collision)
    {
        //�浹�� ������Ʈ�� �̸� ���
        //Debug.Log("�ݸ��� �浹" + collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("�ݸ��� ������ �浹" + collision.gameObject.name);
    }

    private void OnCollisionExit (Collision collision)
    {
        //Debug.Log("�ݸ��� ����Ʈ �浹" + collision.gameObject.name);
    }



    //�ݶ��̴��� isTrigger �ɼ��� Ȱ��ȭ �� ��� ȣ��
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ������Ʈ�� �̸� ���
        //Debug.Log("Ʈ���� �浹" + other.gameObject.name);

        GameManager.i.AddScore();
        Destroy(gameObject);  //������ ������Ʈ ����
    }

    private void OnTriggerStay(Collider other)
    {
        //�浹�� ������Ʈ�� �̸� ���
        //Debug.Log("Ʈ���� ������ �浹" + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        //�浹�� ������Ʈ�� �̸� ���
        //Debug.Log("Ʈ���� ����Ʈ �浹" + other.gameObject.name);
    }
}

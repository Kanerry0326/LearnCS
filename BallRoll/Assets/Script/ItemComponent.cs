using UnityEngine;

public class ItemComponent : MonoBehaviour
{
    //충돌 조건
    //충돌하는 두 오브젝트 다 콜라이더 컴포넌트가 포함되어있어야 함
    //충돌하는 두 오브젝트 중 한 오브젝트라도 RigidBody 컴포넌트가 포함되어있어야 함.

    //콜라이더의 isTrigger 옵션이 비활성화 일 경우 호출

    //최초 충돌 시 한 번 호출
    private void OnCollisionEnter(Collision collision)
    {
        //충돌된 오브젝트의 이름 출력
        //Debug.Log("콜리전 충돌" + collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("콜리젼 스테이 충돌" + collision.gameObject.name);
    }

    private void OnCollisionExit (Collision collision)
    {
        //Debug.Log("콜리젼 엑시트 충돌" + collision.gameObject.name);
    }



    //콜라이더의 isTrigger 옵션이 활성화 일 경우 호출
    private void OnTriggerEnter(Collider other)
    {
        //충돌된 오브젝트의 이름 출력
        //Debug.Log("트리거 충돌" + other.gameObject.name);

        GameManager.i.AddScore();
        Destroy(gameObject);  //아이템 오브젝트 삭제
    }

    private void OnTriggerStay(Collider other)
    {
        //충돌된 오브젝트의 이름 출력
        //Debug.Log("트리거 스테이 충돌" + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        //충돌된 오브젝트의 이름 출력
        //Debug.Log("트리거 엑시트 충돌" + other.gameObject.name);
    }
}

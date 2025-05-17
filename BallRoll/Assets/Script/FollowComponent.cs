using UnityEngine;

public class FollowComponent : MonoBehaviour
{
    Transform ballTrans;        //공 오브젝트의 TransForm 컴포넌트를 담아둘 변수.
    Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballTrans = GameObject.Find("Ball").GetComponent<Transform>();
        //하이어라키에 있는 오브젝트 중 Ball 이라는 이름의 오브젝트를 찾아서 
        //만약 있다면 해당 오브젝트의 컴포넌트 중 Transform 컴포넌트를
        //ballTrans변수에 참조, 연결.

        offset = transform.position - ballTrans.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        //Debug.Log(ballTrans.position);
        //카메라의 위치를 공의 위치로 변경
        transform.position = ballTrans.position + offset;
    }
}

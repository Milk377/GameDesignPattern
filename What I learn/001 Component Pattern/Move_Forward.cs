using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum MoveDirection
{
    MOVE_RIGHT = 0, MOVE_LEFT = 1

}
public class Move_Forward : MonoBehaviour
{

    // 초기 이동 방향 설정
    // 코루틴 사용을 위해 클래스 전역 변수로 설정
    MoveDirection nowMoving = MoveDirection.MOVE_RIGHT;

    // 편의를 위해 이동속도의 접근 제한자를 public 으로 설정 
    public float moveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("MoveForward");
    }

    void CheckAndChangeMoveState()
    {
        // Check Move direction and change state
        if (transform.position.x > 10)
        {
            nowMoving = MoveDirection.MOVE_LEFT;

        }
        else if (transform.position.x < -10)
        {
            nowMoving = MoveDirection.MOVE_RIGHT;
        }

    }

    void Moving()
    {
        // dir == 1 , x++
        // dir == -1 , x--
        int dir = 1;
        
        if(nowMoving == MoveDirection.MOVE_LEFT)
        {
            dir = -1;
            transform.Translate(dir * moveSpeed * Vector3.right * Time.deltaTime , Space.World);
        }
        else if (nowMoving == MoveDirection.MOVE_RIGHT)
        {
            dir = +1;
            transform.Translate(dir * moveSpeed * Vector3.right * Time.deltaTime, Space.World);
        }
    }


    IEnumerator MoveForward()
    {
        while(true)
        {
            CheckAndChangeMoveState();

            Moving();
         

            yield return new WaitForSeconds(0.5f);
        }
    }
 
}

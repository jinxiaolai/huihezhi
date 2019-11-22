using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //目标点坐标
    private Vector3 mTargetPos;
       
    void Start()
    {
        mTargetPos = transform.position;
    }
    void Update()
    {
        //移动
        transform.Translate((mTargetPos - transform.position) * 0.5f * Time.deltaTime);
        //按下鼠标左键时
        if (Input.GetMouseButton(0))
        {
            //播放跑步
            //GetComponent<Animation>().Play();
            //获取屏幕坐标
            Vector3 mScreenPos = Input.mousePosition;
            //定义射线
            Ray mRay = Camera.main.ScreenPointToRay(mScreenPos);
            RaycastHit mHit;
            //判断射线是否击中地面
            if (Physics.Raycast(mRay, out mHit))
            {
                if (mHit.collider.gameObject.tag == "back")
                {
                    //获取目标坐标
                    mTargetPos = mHit.point;
                }
            }
        }
    }

}

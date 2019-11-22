using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class goToBattle : MonoBehaviour
{
    private void Update()
    {
        battle();
    }
    public void battle()
  {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mScreenPos = Input.mousePosition;
            //定义射线
            Ray mRay = Camera.main.ScreenPointToRay(mScreenPos);
            RaycastHit mHit;
            //判断射线是否击中地面
            if (Physics.Raycast(mRay, out mHit))
            {
                if (mHit.collider.gameObject.tag == "xixuegui")
                {
                    SceneManager.LoadScene("战斗");
                }
            }
        }

  }
}

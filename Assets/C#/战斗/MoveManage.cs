using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveManage : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.collider.gameObject.tag == "JN1")
                {
                    GameObject.Find("role").GetComponent<Role>().CanMove = true;
                }
            }
        }

    }
}

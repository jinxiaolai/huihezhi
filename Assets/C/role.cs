using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class role : MonoBehaviour
{
    private int maxHp;
    private int hp;
    private int damage;
    RaycastHit hit;
    Ray ray;
    Vector3 attackM;

    public  void Start()
    {
        maxHp = 100;
        hp = 50;
        damage = 20;
        GameObject HP = GameObject.Find("HP");
    }

    // Update is called once per frame
void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            attackM = Input.mousePosition;
            ray = Camera.main.ScreenPointToRay(attackM);
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.collider.gameObject.tag=="JN")
                {
                    Debug.Log("选择了技能");
                }
                if (hit.collider.gameObject.tag == "monster")
                {
                    Debug.Log("3333技能");
                }
            }
        }
    }
    void Attack()
    {
        Debug.Log("开始打怪2222");

    }
}

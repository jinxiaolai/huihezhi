using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : MonoBehaviour
{
    public bool canMove;
    private int maxHp;
    private int hp;
    private int damage;
    public Transform monster;
    Vector3 pos;

    public  void Start()
    {
        maxHp = 100;
        hp = 50;
        damage = 20;
        GameObject HP = GameObject.Find("HP");
        pos = transform.position;
    }

    public bool CanMove
    {
        get {return canMove; }
        set{ canMove = value; }
    }


    void Update()
    {
        if (canMove == true)
        {
            //移动
            Move();
            //施法
            Attack();
            //回来
            Back();
        }
    }

    void Move()
    {
        //transform.Translate((monster.position - transform.position + new Vector3(2.5f, -1f, 0)) * 0.7f * Time.deltaTime);
        if (Vector3.Distance(monster.position, transform.position) > 3f)
            transform.position = Vector3.MoveTowards(transform.position, monster.position, 3f * Time.deltaTime);
    }
    void Attack()
    {
        if (Vector3.Distance(monster.position, transform.position) <= 3f)
            Debug.Log("1");
    }
    void Back()
    {
        if (Vector3.Distance(monster.position, transform.position) <= 3f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(115, -24, 0), 3f * Time.deltaTime);
            Debug.Log("回来");
        }

    }
}

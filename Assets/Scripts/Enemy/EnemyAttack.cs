using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    public float phamvitancong = 5f;
    NavMeshAgent agent;
    Transform player;
    Vector3 kc=new Vector3(2,2,2);
    EnemyAi ai;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        GameObject player = GameObject.FindWithTag("player");
        if(player!=null)
        {
            float khoangcachbancuaenemy = Vector3.Distance(transform.position, player.transform.position);
            if (khoangcachbancuaenemy < phamvitancong)
            {
                ai.
                enemishoot();
                duoitheoplayer();
            }
        }
        
       
    }
    void enemishoot()
    {
        Debug.Log("da tim thay playuer ");
    }
    void duoitheoplayer()
    {
        transform.position=transform.position+kc;
    }
}

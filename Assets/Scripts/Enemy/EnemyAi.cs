using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform[] diemden;
    private int diempointhenai;
    public float speed;
    Vector3 kc = new Vector3(1, 1, 1);
    float distance;
    public Transform diembandan;
    public GameObject bulletprefabs;
    public float timedelay;


    public bool dcphepdichuyendenpoint;

    bool Isfollow;
    float phamvitancong = 5f;
    //float enemy_stop=2f
    public Transform player;
    bool dangtancong;



    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        diempointhenai = 0;
        dichuyenwaypoint();
        dcphepdichuyendenpoint = true;


    }
    private void Update()
    {

        GameObject player = GameObject.FindWithTag("player");
        if (player == null)
        {
            if (!agent.pathPending && agent.remainingDistance < 0.1f)
            {
                dichuyenwaypoint();
            }
            return;
        }

        float khoangcachbancuaenemy = Vector3.Distance(transform.position, player.transform.position);

        if (!dangtancong && khoangcachbancuaenemy > phamvitancong)
        {
            dichuyenwaypoint();
        }

        if (dangtancong && khoangcachbancuaenemy > phamvitancong)
        {
            if (agent.isStopped == true)
            {
                agent.isStopped = false;
            }
            duoitheoplayer();

        }
        if (khoangcachbancuaenemy <= phamvitancong)
        {
            isAttacking();

        }
    }
    float countTime;
    void isAttacking()
    {

        if (countTime >= timedelay)
        {
            GameObject bullet = Instantiate(bulletprefabs, diembandan.position, diembandan.rotation);


            bullet bulletComponent = bullet.GetComponent<bullet>();
            if (bulletComponent != null)
            {

                bulletComponent.speed = 20f;
            }
            countTime = 0;
        }

        countTime += Time.deltaTime;

        dangtancong = true;
        if (dangtancong)
        {
            agent.isStopped = true;
        }
    }
    void duoitheoplayer()
    {
        if (player != null)
        {
            agent.SetDestination(player.position);
        }


    }
    //void banplayer()
    //{

    //}


    void dichuyenwaypoint()
    {
        float diempoint = Vector3.Distance(transform.position, diemden[diempointhenai].position);
        if (dcphepdichuyendenpoint)
        {


            agent.SetDestination(diemden[diempointhenai].position);
            if (diempoint < 1)
            {   

                diempointhenai++;
                if (diempointhenai >= diemden.Length)
                    diempointhenai = 0;
            }

        }

    }
    void tangIndex()
    {
        diempointhenai++;
        if (diempointhenai >= diemden.Length)
            diempointhenai = 0;
    }
}

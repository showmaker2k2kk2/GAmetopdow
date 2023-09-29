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
    Vector3 target;
    float distance;
    public bool dcphepdichuyendenpoint ;

    //public Transform player;
    bool Isfollow;
    //Vector3 phamvitancong=


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        diempointhenai = 0;
        dichuyenwaypoint();
        dcphepdichuyendenpoint = true;
      

}
    private void Update()
    {
        if (dcphepdichuyendenpoint) 
        {
            if (!agent.pathPending && agent.remainingDistance < 0.1f)
            {

                dichuyenwaypoint();
            }
        }
       

    }


    void dichuyenwaypoint()
    {
        agent.SetDestination(diemden[diempointhenai].position);

        diempointhenai++;
        if (diempointhenai >= diemden.Length)
            diempointhenai = 0;

    }
    void tangIndex()
    {
        diempointhenai++;
        if (diempointhenai >= diemden.Length)
            diempointhenai = 0;
    }   
}

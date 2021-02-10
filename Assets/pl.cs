using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class pl : MonoBehaviour
{
    public Transform Pointer;
    public LayerMask toClickOn;
    public AudioSource clicked;
    private UnityEngine.AI.NavMeshAgent myAgent;
    void Start()
    {
        myAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(myRay, out hit, 1000, toClickOn))
            {
                Pointer.position = hit.point;
                myAgent.SetDestination(hit.point);
                clicked.Play();
                Debug.Log("Come Here!");
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl : MonoBehaviour
{
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
            
            if (Physics.Raycast(myRay, out hit, 20, toClickOn))
            {
                myAgent.SetDestination(hit.point);
                clicked.Play();
                Debug.Log("Come Here!");
            }
        }
    }
}

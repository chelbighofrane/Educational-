using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animals_Manager : MonoBehaviour
{
    GameObject animal = null;
    public Animator MyAnim;
    public NavMeshAgent MyAgent;

    public bool Touch;
    public bool Walk;
    
    // Use this for initialization
    void Start()
    {

        MyAnim = GetComponent<Animator>();
        MyAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {

        MyAnim.SetBool("Touch", Touch);
        MyAnim.SetBool("Walk", Walk);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (!Walk)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(ray, out hit, 3000))
                {
                    if (hit.collider.tag == "bear")
                    {
                        Touch = true;

                        hit.transform.gameObject.GetComponent<AudioSource>().Play();

                    }
                    if (hit.collider.tag == "elephant")
                        {
                           Touch = true;
                           hit.transform.gameObject.GetComponent<AudioSource>().Play();
                    }

                

                    if (hit.collider.tag == "zebre")
                    {
                        Touch = true;
                        hit.transform.gameObject.GetComponent<AudioSource>().Play();

                    }

                   if (hit.collider.tag == "rabbit")
                        {
                        Touch = true;
                        hit.transform.gameObject.GetComponent<AudioSource>().Play();

                    }
                    if (hit.collider.tag == "crocodile")
                    {
                        Touch = true;
                        hit.transform.gameObject.GetComponent<AudioSource>().Play();

                    }
                    if (hit.collider.tag == "rhinoceros")
                    {
                        Touch = true;
                        hit.transform.gameObject.GetComponent<AudioSource>().Play();

                    }



                }


            }
            }

            if (!Touch)
            {
                if (Input.GetMouseButtonDown(0))
                {

                    if (Physics.Raycast(ray, out hit, 3000))
                    {
                        Walk = true;
                        MyAgent.SetDestination(hit.point);
                    }
                }

                if (!MyAgent.pathPending && MyAgent.remainingDistance <= MyAgent.stoppingDistance)
                {
                    Walk = false;

                }
            }


        }

    
    public void S()
    {
        Touch = false;
        animal= null;
    }

 }  

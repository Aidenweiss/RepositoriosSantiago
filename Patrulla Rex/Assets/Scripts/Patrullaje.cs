using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mapa;

public class Patrullaje : Navmesh
{
    public Transform position;
    public GameObject[] waypoints;
    public float range;
    public float eSpeed;
    public float iSpeed;
    public float tiempo;
    public int i;

    void Awake()
    {
        Kawake();
    }
    // Use this for initialization
    void Start ()
    {
        waypoints = GameObject.FindGameObjectsWithTag("WayPoint");
       // position = GameObject.Find("Hero").transform;
        iSpeed = eSpeed;

	}
	
	// Update is called once per frame
	void Update ()
    {
        Patrullar();
        agent.SetDestination(waypoints[i].transform.position);

    }
    void Patrullar()
    {
        if (i < waypoints.Length)
        {
            float direction = (waypoints[i].transform.position - transform.position).magnitude;
            if (direction > range)
            {
               
                transform.position += Vector3.Normalize(waypoints[i].transform.position - transform.position) * eSpeed * Time.deltaTime;

            }
            if (direction < range)
            {
               i = Random.Range(0,waypoints.Length);
            }
           
        }
        else
        {
            if (tiempo > 0)
            {
                eSpeed = 0;
                tiempo -= Time.deltaTime;
            }
            else
            {
                i = 0;
                tiempo = 1;
                eSpeed = iSpeed;
            }
        }
    }
}

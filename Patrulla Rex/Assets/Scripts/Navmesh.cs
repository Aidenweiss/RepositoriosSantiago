using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace mapa
{
    public class Navmesh : MonoBehaviour
    {
        public NavMeshAgent agent;
        public Transform target;

        // Use this for initialization
        void Start ()
        {
		
	    }
	
	    // Update is called once per frame
	    void Update ()
        {
            Meta();
	    }
        public void Meta()
        {
            agent.SetDestination(target.position);
        }
        public void Kawake()
        {
            agent = GetComponent<NavMeshAgent>();
        }
    }
    
}

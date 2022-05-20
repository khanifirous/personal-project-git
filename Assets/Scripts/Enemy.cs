using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Enemy : MonoBehaviour
{
    private NavMeshAgent enemy;
    private Transform player;
    private GameObject text;
    private float health = 3;
    public ParticleSystem bloodSplat;
    public bool isAlive = true;
    private Rigidbody enemyRb;
    public GameObject enemyRagdoll;
    private GameManager gameManager; 
    
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
        text = GameObject.Find("death text");
        enemyRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        enemy.SetDestination(player.transform.position);
        
        if (health == 0)
        {
            isAlive = false;
            GetComponent<NavMeshAgent>().enabled = false;
            Destroy(gameObject);
            Instantiate(enemyRagdoll, transform.position, transform.rotation); 
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Gun"))
        {
            health -- ;
            bloodSplat.Play();
        }
    }
}

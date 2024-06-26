using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMoving : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float speed = 5f;


    private float boundary = 26.7f;
    private float boundrayY = 13.43f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        transform.up = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

        if (transform.position.x > boundary)
        {
            transform.position = new Vector2(boundary, transform.position.y);
        }

        if (transform.position.x < -boundary)
        {
            transform.position = new Vector2(-boundary, transform.position.y);
        }

        if (transform.position.y < -boundrayY)
        {
            transform.position = new Vector2(transform.position.x, -boundrayY);
        }

        if (transform.position.y > boundrayY)
        {
            transform.position = new Vector2(transform.position.x, boundrayY);
        }
    }


}


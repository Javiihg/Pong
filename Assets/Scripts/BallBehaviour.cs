using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameScoreUI score;
    [SerializeField]
    private Vector3 direction;
    [SerializeField]
    float ballSpeedInitial = 6.0f;
    float ballSpeed;

    // Start is called before the first frame update
    void Start()
    {
        ballSpeed = ballSpeedInitial;
        if (Random.Range(0.0f, 1.0f) < 0.5f)
        {
            Debug.Log("El 50% de las veces pasa esto");
            direction = Vector3.right;
        }
        else
        {
            Debug.Log("El 50% de las veces pasa esto");
            direction = Vector3.left;
        }

        if (Random.Range(0.0f, 1.0f) < 0.5f)
        {
            //direction += Vector3.up;
        }
        else
        {
            //direction += Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("una colisión con " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Cambiar dirección en eje X");
            direction.x = -direction.x;

            Debug.Log("cambiar dirección en eje Y");
            direction.y = Random.Range(-1f, 1f);

            ballSpeed += 0.5f;   
        } 
        else if (collision.gameObject.CompareTag("Border"))
        {
            direction.y = -direction.y;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GoalZoneOne"))
        {
            ResetBall();
            score.GoalScoredPlayerTwo();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.CompareTag("GoalZoneTwo"))
        {
            ResetBall();
            score.GoalScoredPlayerOne();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void ResetBall()
    {
        transform.position = Vector3.zero;
        ballSpeed = ballSpeedInitial;
        direction.x = -direction.x;
        direction.y = Random.Range(-1f, 1f);
    }


}

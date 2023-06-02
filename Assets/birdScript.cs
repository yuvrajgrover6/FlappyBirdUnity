using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public LogicScript logicScript;

    public Rigidbody2D myRigidBody;
    public float flyStrength;

    public AudioSource audioData;
    public bool birdIsAlive = true;

    // Start is called before the first frame update

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {


        if (birdIsAlive && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            myRigidBody.velocity = Vector2.up * flyStrength;

            audioData.Play(0);

        }

        if (birdIsAlive && Input.GetMouseButtonDown(0))
        {

            myRigidBody.velocity = Vector2.up * flyStrength;
            audioData.Play(0);


        }

        if (transform.position.y < -12)
        {
            logicScript.gameOver();
            birdIsAlive = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        birdIsAlive = false;
    }


}

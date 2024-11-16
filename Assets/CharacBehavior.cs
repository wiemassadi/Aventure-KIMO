using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacBehavior : MonoBehaviour {


	public float runSpeed;
	public float jumpHight;
    public Rigidbody2D rb;
    public bool isGrounded = false;
    public float timeOut;


	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		SetVelocity(runSpeed);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            Jump();
        }
	}


	void Jump(){
		GameObject.Find("JumpSound").GetComponent<AudioSource>().Play(0);
		rb.velocity += new Vector2 (0, jumpHight);
		isGrounded = false;
	}


	void OnCollisionEnter2D(Collision2D col){


		if(col.gameObject.CompareTag("Ground")){
			isGrounded = true;
		}
    }


    void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Obstacle")){
			StartCoroutine(ObstacleFind());
		}
    }


    IEnumerator ObstacleFind()
    {
    	yield return new WaitForSeconds(0.1f);
    	GameObject.FindWithTag("Monster").GetComponent<MonsterSystem>().GoCloser();
        SetVelocity(runSpeed/2);
        yield return new WaitForSeconds(1);
        SetVelocity(runSpeed);
        yield return new WaitForSeconds(timeOut);
        GameObject.FindWithTag("Monster").GetComponent<MonsterSystem>().GoFurther();
    }


    void SetVelocity(float speed){
    	rb.velocity = new Vector2 (0, 0);
    	rb.velocity = new Vector2 (speed, 0);
    }
}

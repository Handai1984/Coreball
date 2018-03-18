using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {
    public float speed = 10f;
	
	void Start () {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed ;
	}
	
	
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Feipan"))
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.transform.SetParent(collision.gameObject.GetComponent<Transform>());
        }
        else if (collision.gameObject.CompareTag("Zhentou"))
        {
        Camera.main.backgroundColor = Color.red;
            StartCoroutine(ReStart());
        }
        
    }

    IEnumerator  ReStart()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour {

	public Rigidbody2D rb;
	public float forcaPulo = 200f;

	public Text pontosText;
	private int pontos = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Pular ();
		}
	}

	void Pular ()
	{
		rb.velocity = Vector2.zero;
		rb.AddForce (Vector2.up * forcaPulo);
	}

	void OnTriggerEnter2D (Collider2D colisor) {
		if (colisor.CompareTag("ColisorPontos")) {
			pontos = pontos + 1;
			// Mesma coisa que: pontos++;
			// Mesma coisa que: pontos += 1;
			pontosText.text = "Pontos: " + pontos;
		}
	}

	void OnCollisionEnter2D(Collision2D colisao) {
		if (colisao.gameObject.CompareTag("Inimigos")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}

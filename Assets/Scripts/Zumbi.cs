using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour
{
	public float delayAndar = 1f;
	public float velocidade = 0.35f;

	private bool andando = false;

	private Rigidbody rb;
	public Animator animator;

	private GameObject jogador;

	// Use this for initialization
	private void Start()
	{
		rb = GetComponent<Rigidbody>();

		Invoke("Andar", delayAndar);

		jogador = GameObject.Find("Jogador");
		transform.LookAt(jogador.transform);
	}

	private void Andar()
	{
		andando = true;
	}

	// Update is called once per frame
	private void Update()
	{
		if (andando)
		{
			rb.velocity = transform.forward * velocidade;
		}
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.CompareTag("Projétil"))
		{
			Destroy(collider.gameObject);
			Matar();
		}
	}

	private void Matar()
	{
		andando = false;
		animator.SetTrigger("Die");
	}
}

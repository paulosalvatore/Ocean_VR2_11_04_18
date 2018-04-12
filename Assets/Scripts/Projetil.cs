using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
	public float velocidade = 5f;
	public float delayDestruir = 4f;

	// Use this for initialization
	private void Start()
	{
		Destroy(gameObject, delayDestruir);
	}

	// Update is called once per frame
	private void Update()
	{
		transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
	}
}

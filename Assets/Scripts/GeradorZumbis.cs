using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
	public GameObject zumbiPrefab;
	public float intervalo = 2f;
	public float area = 4f;

	// Use this for initialization
	private void Start()
	{
		InvokeRepeating("GerarZumbis", intervalo, intervalo);
	}

	private void GerarZumbis()
	{
		GameObject zumbi = Instantiate(zumbiPrefab);

		Vector2 posicaoAleatoria = Random.insideUnitCircle * area;

		zumbi.transform.position = new Vector3(
			posicaoAleatoria.x,
			0f,
			posicaoAleatoria.y
		);
	}
}

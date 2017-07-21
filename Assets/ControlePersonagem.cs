using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour {
	Rigidbody2D rb;
	[SerializeField] float velocidade;
	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.position += new Vector2 (Input.GetAxis ("Horizontal") * Time.deltaTime * velocidade, 0f);
		transform.rotation = Quaternion.identity;
	}
}

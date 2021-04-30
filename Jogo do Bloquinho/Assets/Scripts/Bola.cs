using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public bool jogoIniciou;
    public float direcaoX;
    public float direcaoY;
    public Rigidbody2D oRigidBody2D;
    public AudioSource oSomBola;
    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;

    // Start is called before the first frame update
    void Start(){
        jogoIniciou = false;
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            LancarBola();
        }
    }

    private void LancarBola(){
        if(jogoIniciou == false){
            oRigidBody2D.velocity = new Vector2(direcaoX, direcaoY);
            jogoIniciou = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        oSomBola.Play();
        oRigidBody2D.velocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
    }
}

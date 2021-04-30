using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    public GameObject SomBloco;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().AumentarQuantidadeBlocos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Bola")){
            FindObjectOfType<GameManager>().DiminuirQuantidadeBlocos();
            Instantiate(SomBloco, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}

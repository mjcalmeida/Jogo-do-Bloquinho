using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int quantidadeBlocos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            SairDoJogo();
        }
    }

    public void AumentarQuantidadeBlocos(){
        quantidadeBlocos += 1;
    }

    public void DiminuirQuantidadeBlocos(){
        quantidadeBlocos -= 1;

        if(quantidadeBlocos <= 0){
            if(SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } else {
                SceneManager.LoadScene(0);
            }
        }
    }

    private void SairDoJogo(){
        Application.Quit();
    }
}

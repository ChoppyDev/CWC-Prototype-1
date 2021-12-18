using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(player.transform.position.y < -1.0f)
        {
            ReloadGame();
        }
        if (Input.GetKey("r"))
        {
            ReloadGame();
        }
    }
    
    void ReloadGame()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

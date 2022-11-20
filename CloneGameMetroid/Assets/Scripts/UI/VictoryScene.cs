using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VictoryScene : MonoBehaviour
{
    public string victoryScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 1f;

            Destroy(PlayerHealthController.instance.gameObject);
            PlayerHealthController.instance = null;

            Destroy(RespawnController.instance.gameObject);
            RespawnController.instance = null;

            Destroy(UIController.instance.gameObject);
            UIController.instance = null;
            Destroy(gameObject);

            PlayerPrefs.DeleteAll();

            AudioManager.instance.PlayVictoryMusic();
            SceneManager.LoadScene(victoryScene);
            
        }
    }

   

    
}

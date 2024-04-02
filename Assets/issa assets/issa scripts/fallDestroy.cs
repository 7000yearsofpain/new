using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallDestroy : MonoBehaviour
{
    // This is the number that determines height of death
    public int deathY = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deathY)
        {
            Scene scene = SceneManager.GetActiveScene();
            Debug.Log("I died");
            Destroy(gameObject);

            //Grab the scene  manager and make it load a scene
            SceneManager.LoadScene(scene.name);
        }
    }
}

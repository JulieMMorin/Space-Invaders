using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int birds = 27;
    public GameObject john;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Subtract()
    {
        birds = birds - 1;
        john.GetComponent<Text>().text = birds.ToString();

        if (birds == 0)
        {
            SceneManager.LoadScene("Level 2");
        }
    }
}

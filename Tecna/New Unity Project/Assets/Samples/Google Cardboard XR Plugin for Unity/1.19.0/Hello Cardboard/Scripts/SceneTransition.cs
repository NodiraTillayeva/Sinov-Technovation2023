using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        GazeAt(true);
    }


    public void OnPointerExit()
    {
        GazeAt(false);
    }


    public void GazeAt(bool gazing){
        if(gazing)
        {
            SceneManager.LoadScene("Scene2");
        }
        else
        {
           
        }
    }
}

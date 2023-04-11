using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    [SerializeField]private Color inactiveColor;
    [SerializeField]private Color gazedAtColor;
    [SerializeField]private GameObject playerCameraGameobj;

    private bool colorChanging=false;
    private AudioSource keyPickUpAudioSource;
    private float myTimer= 0f;

    private MeshRenderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer= GetComponent<MeshRenderer>();
        myRenderer.material.color = inactiveColor;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (colorChanging)
        {
            myRenderer.material.color = Color.Lerp(myRenderer.material.color, gazedAtColor, Time.deltaTime/2f);
            myTimer += Time.deltaTime;
            if(myTimer >= 2f)
            {
                //Teleport camera to the location
                SceneManager.LoadScene("Scene2");
                // Vector3 TeleportPose = new Vector3(transform.position.x, playerCameraGameobj.transform.position.y,transform.position.z);
                // playerCameraGameobj.transform.position = TeleportPose;
            }
        }
    }

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        GazeAt(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        GazeAt(false);
    }


    public void GazeAt(bool gazing){
        if(gazing)
        {
            colorChanging=true;
            // myRenderer.material.color= gazedAtColor;
        }
        else
        {
            myTimer = 0f;
            colorChanging=false;
            // myRenderer.material.color= inactiveColor;
        }
    }
}

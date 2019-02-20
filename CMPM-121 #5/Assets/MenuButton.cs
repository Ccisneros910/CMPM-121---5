using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public Button playButton;
    public Camera playerCamera;
    public Camera menuCamera;
    public Canvas menu;
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(ChangeCameras);
    }
    void ChangeCameras()
    {
        menuCamera.enabled = false;
        playerCamera.enabled = true;
        menu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

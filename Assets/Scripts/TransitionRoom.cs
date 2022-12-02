using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

/// <summary>
/// Able to transition of all rooms in the tour
/// </summary>
public class TransitionRoom : MonoBehaviour
{
    // Canvas link to the cantina
    GameObject CantinaCanvas;
    // Sphere where is the cantina video
    GameObject CantinaSphere;
    // Canvas link to the livingRoom
    GameObject LivingRoomCanvas;
    // Sphere where is the livingRoom video
    GameObject LivingRoomSphere;

    // Start is called before the first frame update
    void Start()
    {
        CantinaCanvas = GameObject.Find("CantinaCanvas");
        CantinaSphere = GameObject.Find("Cantina");
        LivingRoomCanvas = GameObject.Find("LivingRoomCanvas");
        LivingRoomSphere = GameObject.Find("LivingRoom");
    }

    // Enable the canvas and play the video of livingRoom
    void enableLivingRoom()
    {
        LivingRoomCanvas.GetComponent<Canvas>().enabled = true;
        LivingRoomSphere.GetComponent<VideoPlayer>().Play();
    }

    // Disable the canvas and stop the video of livingRoom
    void disableLivingRoom()
    {
        LivingRoomCanvas.GetComponent<Canvas>().enabled = false;
        LivingRoomSphere.GetComponent<VideoPlayer>().Stop();
    }

    // Enable the canvas and play the video of Cantina
    void enableCantina()
    {
        CantinaCanvas.GetComponent<Canvas>().enabled = true;
        CantinaSphere.GetComponent<VideoPlayer>().Play();
    }

    // Disable the canvas and play the video of Cantina
    void disableCantina()
    {
        CantinaCanvas.GetComponent<Canvas>().enabled = false;
        CantinaSphere.GetComponent<VideoPlayer>().Stop();
    }

    /// <summary>
    /// Make the transition of cantina to living room
    /// When a button is trigger
    /// </summary>
    public void CantinaToLivingRoom()
    {
        disableCantina();
        enableLivingRoom();
    }

    /// <summary>
    /// Make the transition of living room to cantina
    /// When a button is trigger
    /// </summary>
    public void LivingRoomToCantina()
    {
        disableLivingRoom();
        enableCantina();
    }
}

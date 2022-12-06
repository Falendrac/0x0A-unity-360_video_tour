using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

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
    // Canvas to make the blackscreen
    GameObject BlackScreen;
    Animator BlackScreenAnimator;

    // Start is called before the first frame update
    void Start()
    {
        CantinaCanvas = GameObject.Find("CantinaCanvas");
        CantinaSphere = GameObject.Find("Cantina");
        LivingRoomCanvas = GameObject.Find("LivingRoomCanvas");
        LivingRoomSphere = GameObject.Find("LivingRoom");
        BlackScreen = GameObject.Find("BlackScreen");
        BlackScreenAnimator = BlackScreen.GetComponentInChildren<Animator>();
    }

    void ScreenFade()
    {
        BlackScreen.GetComponent<Canvas>().enabled = true;
        BlackScreenAnimator.enabled = true;
    }

    async void ScreenUnfade()
    {
        BlackScreenAnimator.SetBool("TransitionFinished", true);
        await Task.Delay(3500);
        BlackScreenAnimator.SetBool("TransitionFinished", false);
        BlackScreenAnimator.enabled = false;
        BlackScreen.GetComponent<Canvas>().enabled = false;
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
    public async void CantinaToLivingRoom()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableCantina();
        enableLivingRoom();
        ScreenUnfade();
    }

    /// <summary>
    /// Make the transition of living room to cantina
    /// When a button is trigger
    /// </summary>
    public async void LivingRoomToCantina()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableLivingRoom();
        enableCantina();
        ScreenUnfade();
    }
}

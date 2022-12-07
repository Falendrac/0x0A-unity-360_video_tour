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
    // Canvas to make the blackscreen
    GameObject BlackScreen;
    // Animator in child of BlackScreen
    Animator BlackScreenAnimator;
    /// <summary>
    /// Assign the current canvas enable in Unity
    /// </summary>
    public GameObject currentCanvas;
    /// <summary>
    /// Asign the current sphere with the video player played in Unity
    /// </summary>
    public GameObject currentVideo;
    /// <summary>
    /// Assign the target canvas of the new scene in Unity
    /// </summary>
    public GameObject targetCanvas;
    /// <summary>
    /// Assign the target sphere with the video player with the video of the
    /// next scene in Unity
    /// </summary>
    public GameObject targetVideo;

    // Start is called before the first frame update
    void Start()
    {
        BlackScreen = GameObject.Find("BlackScreen");
        BlackScreenAnimator = BlackScreen.GetComponentInChildren<Animator>();
    }

    // Enable the canvas of BlackScreen GameObject and enable the animator to 
    // play the animation of fade
    void ScreenFade()
    {
        BlackScreen.GetComponent<Canvas>().enabled = true;
        BlackScreenAnimator.enabled = true;
    }

    // Set the transition boolean of animator in true, to play the unfade
    // animation. The method is asynchronous to let the animation playing
    // Reset the boolean at false and disable Animator and Canvas of BlackScreen
    async void ScreenUnfade()
    {
        BlackScreenAnimator.SetBool("TransitionFinished", true);
        await Task.Delay(3500);
        BlackScreenAnimator.SetBool("TransitionFinished", false);
        BlackScreenAnimator.enabled = false;
        BlackScreen.GetComponent<Canvas>().enabled = false;
    }

    // Enable the canvas and play the video of target
    void enableTarget()
    {
        targetCanvas.GetComponent<Canvas>().enabled = true;
        targetVideo.GetComponent<VideoPlayer>().Play();
    }

    // Disable the canvas and stop the video of current
    void disableCurrent()
    {
        currentCanvas.GetComponent<Canvas>().enabled = false;
        currentVideo.GetComponent<VideoPlayer>().Stop();
    }

    /// <summary>
    /// Make the transition of current scene to target scene
    /// When transition button is trigger
    /// The method is asynchronous to let the fade animation playing
    /// </summary>
    public async void doTransition()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableCurrent();
        enableTarget();
        ScreenUnfade();
    }
}

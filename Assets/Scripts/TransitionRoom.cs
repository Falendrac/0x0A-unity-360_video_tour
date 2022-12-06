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
    // Canvas link to the cantina
    GameObject CantinaCanvas;
    // Sphere where is the cantina video
    GameObject CantinaSphere;
    // Canvas link to the cube
    GameObject CubeCanvas;
    // Sphere where is the cube video
    GameObject CubeSphere;
    // Canvas link to the livingRoom
    GameObject LivingRoomCanvas;
    // Sphere where is the livingRoom video
    GameObject LivingRoomSphere;
    // Canvas link to the mezzanine
    GameObject MezzanineCanvas;
    // Sphere where is the mezzanine
    GameObject MezzanineSphere;

    // Start is called before the first frame update
    void Start()
    {
        BlackScreen = GameObject.Find("BlackScreen");
        BlackScreenAnimator = BlackScreen.GetComponentInChildren<Animator>();
        CantinaCanvas = GameObject.Find("CantinaCanvas");
        CantinaSphere = GameObject.Find("Cantina");
        CubeCanvas = GameObject.Find("CubeCanvas");
        CubeSphere = GameObject.Find("Cube");
        LivingRoomCanvas = GameObject.Find("LivingRoomCanvas");
        LivingRoomSphere = GameObject.Find("LivingRoom");
        MezzanineCanvas = GameObject.Find("MezzanineCanvas");
        MezzanineSphere = GameObject.Find("Mezzanine");
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

    // Enable the canvas and play the video of Cantina
    void enableCantina()
    {
        CantinaCanvas.GetComponent<Canvas>().enabled = true;
        CantinaSphere.GetComponent<VideoPlayer>().Play();
    }

    // Disable the canvas and stop the video of Cantina
    void disableCantina()
    {
        CantinaCanvas.GetComponent<Canvas>().enabled = false;
        CantinaSphere.GetComponent<VideoPlayer>().Stop();
    }

    // Enable the canvas and play the video of Cube
    void enableCube()
    {
        CubeCanvas.GetComponent<Canvas>().enabled = true;
        CubeSphere.GetComponent<VideoPlayer>().Play();
    }

    // Disable the canvas and stop the video of Cube
    void disableCube()
    {
        CubeCanvas.GetComponent<Canvas>().enabled = false;
        CubeSphere.GetComponent<VideoPlayer>().Stop();
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

    // Enable the canvas and play the video of mezzanine
    void enableMezzanine()
    {
        MezzanineCanvas.GetComponent<Canvas>().enabled = true;
        MezzanineSphere.GetComponent<VideoPlayer>().Play();
    }

    // Disable the canvas and stop the video of mezzanine
    void disableMezzanine()
    {
        MezzanineCanvas.GetComponent<Canvas>().enabled = false;
        MezzanineSphere.GetComponent<VideoPlayer>().Stop();
    }

    /// <summary>
    /// Make the transition of cantina to living room
    /// When the cantina button is trigger
    /// The method is asynchronous to let the fade animation playing
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
    /// Make the transition of cantina to cube
    /// When the cube button is trigger
    /// The method is asynchronous to let the fade animation playing
    /// </summary>
    public async void CantinaToCube()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableCantina();
        enableCube();
        ScreenUnfade();
    }

    /// <summary>
    /// Make the transition of cube to cantina
    /// When the cantina button is trigger
    /// The method is asynchronous to let the fade animation playing
    /// </summary>
    public async void CubeToCantina()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableCube();
        enableCantina();
        ScreenUnfade();
    }

    /// <summary>
    /// Make the transition of cube to living room
    /// When the living room button is trigger
    /// The method is asynchronous to let the fade animation playing
    /// </summary>
    public async void CubeToLivingRoom()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableCube();
        enableLivingRoom();
        ScreenUnfade();
    }

    /// <summary>
    /// Make the transition of cube to mezzanine
    /// When the mezzanine button is trigger
    /// The method is asynchronous to let the fade animation playing
    /// </summary>
    public async void CubeToMezzanine()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableCube();
        enableMezzanine();
        ScreenUnfade();
    }

    /// <summary>
    /// Make the transition of Living room to Cube
    /// when the cube button is trigger
    /// The method is asynchronous to let the fade animation playing
    /// </summary>
    public async void LivingRoomToCube()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableLivingRoom();
        enableCube();
        ScreenUnfade();
    }

    /// <summary>
    /// Make the transition of living room to cantina
    /// When the cantina button is trigger
    /// The method is asynchronous to let the fade animation playing
    /// </summary>
    public async void LivingRoomToCantina()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableLivingRoom();
        enableCantina();
        ScreenUnfade();
    }

    /// <summary>
    /// Make the transition of mezzanine to cube
    /// When the cube button is trigger
    /// The method is asynchronous to let the fade animation playing
    /// </summary>
    public async void MezzanineToCube()
    {
        ScreenFade();
        await Task.Delay(2000);
        disableMezzanine();
        enableCube();
        ScreenUnfade();
    }
}

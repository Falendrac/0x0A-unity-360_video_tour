using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Display the info attached with the current button
/// This script need to be component of a TellMeMore Button
/// </summary>
public class DisplayInfo : MonoBehaviour
{
    /// <summary>
    /// Image gameobject attached with the TellMeMore button
    /// </summary>
    public GameObject InfoAttached;

    /// <summary>
    /// Change the state of hidden of a gameobject
    /// By active or not
    /// </summary>
    public void changeHidden()
    {
        if (!InfoAttached.activeSelf)
        {
            InfoAttached.SetActive(true);
        }
        else
        {
            InfoAttached.SetActive(false);
        }
    }
}

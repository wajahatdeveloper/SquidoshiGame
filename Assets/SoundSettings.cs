using GameCreator.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSettings : MonoBehaviour
{
    public void MasterVolume(float value)
    {
        AudioManager.Instance.SetGlobalMastrVolume(value);
    }

    public void SfxVolume(float value)
    {
        AudioManager.Instance.SetGlobalSoundVolume(value);
    }

    public void MusicVolume(float value)
    {
        AudioManager.Instance.SetGlobalMusicVolume(value);
    }
}
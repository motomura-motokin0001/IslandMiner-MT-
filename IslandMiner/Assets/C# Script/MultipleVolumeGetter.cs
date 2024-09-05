using UnityEngine;
using System.Collections.Generic;

public class MultipleVolumeGetter : MonoBehaviour
{
    // AudioSourceを格納するリスト
    public List<AudioSource> audioSources;

    // 音量を格納するリスト
    private List<float> volumes;

    void Start()
    {
        // 音量リストの初期化
        volumes = new List<float>();

        // 各AudioSourceの音量を取得
        foreach (AudioSource audioSource in audioSources)
        {
            float volume = audioSource.volume;
            volumes.Add(volume);
            Debug.Log("音量: " + volume);
        }
    }
}

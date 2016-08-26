using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 * 音声に関する処理を扱うクラス．
 * BGMとSEの2種類が存在し，別々に取り扱うことができる．
 * BGMはループ再生される．SEは複数の音声を同時に鳴らすことができる．
 * 音声ファイルはそれぞれリストによる番号で管理される．
 */
public class SoundsManager : MonoBehaviour {
    // SE用AudioSource
    AudioSource soundSource;

    // BGM用AudioSource
    AudioSource musicSource;

    // SE用AudioSourceのリスト．番号で管理
    public List<AudioClip> soundClips = new List<AudioClip>();

    // SE用AudioSourceのリスト．番号で管理
    public List<AudioClip> musicClips = new List<AudioClip>();

    // SEのマスタボリューム
    [SerializeField, Range(0, 1)]
    public float soundMasterVolume = 1.0f;

    // BGMのマスタボリューム
    [SerializeField, Range(0, 1)]
    public float musicMasterVolume = 1.0f;

    // 初期化
    void Start()
    {
        soundSource = GetComponent<AudioSource>();
        soundSource.volume = soundMasterVolume;
        musicSource = GetComponent<AudioSource>();
        musicSource.loop = true;
        musicSource.volume = musicMasterVolume;
    }

    // SEを再生する．index: soundClipsの番号
    public void PlaySE(int index)
    {
        soundSource.PlayOneShot(soundClips[index]);
    }

    // SEを再生する．index: soundClipsの番号，volume: スケールする音量[0-1]
    public void PlaySE(int index, float volume)
    {
        soundSource.PlayOneShot(soundClips[index], volume);
    }

    // BGMを再生する．index: musicClipsの番号
    public void PlayBGM(int index)
    {
        musicSource.Stop();
        musicSource.clip = musicClips[index];
        musicSource.Play();

    }

    // BGMを再生する．index: musicClipsの番号，volume: スケールする音量[0-1]
    public void PlayBGM(int index, float volume)
    {
        musicSource.Stop();
        musicSource.clip = musicClips[index];
        musicSource.volume = musicMasterVolume * volume;
        musicSource.Play();

    }

    // BGMを停止する．
    public void StopBGM()
    {
        musicSource.Stop();
    }

}

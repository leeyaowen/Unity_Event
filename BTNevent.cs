using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Vuforia;

public class BTNevent : MonoBehaviour
{
    public Button Vbtn;
    GameObject vp;

    void Start()
    {
        Button btn = Vbtn.GetComponent<Button>();
        btn.onClick.AddListener(BtnClick);
        vp = GameObject.Find("Video Player");
    }

    void BtnClick()
    {
        if (vp.GetComponent<VideoPlayer>().isPlaying)
        {
            vp.GetComponent<VideoPlayer>().Pause();
        }
        else
        {
            vp.GetComponent<VideoPlayer>().Play();
        }
    }
}

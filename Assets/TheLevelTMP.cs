using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using TMPro;
using UnityEngine;

public class TheLevelTMP : Singleton<TheLevelTMP>
{
    public TextMeshProUGUI textMeshProUgui;

    public int point;

    public float time, timecount = 1;

    // Start is called before the first frame update
    void Start()
    {
        time = timecount;
        point = 0;
        textMeshProUgui.SetText($"0");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.currentState == State.Playing)
        {
            time -= Time.deltaTime;

            if (time < 0)
            {
                time = timecount;
                textMeshProUgui.SetText($"{point}");
            }
        }
    }
}
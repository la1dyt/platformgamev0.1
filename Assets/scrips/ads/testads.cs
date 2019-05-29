using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class testads : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        Monetization.Initialize("3166054",false);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButton("Fire1"))
        {
            if (Monetization.IsReady("video"))
            {
                ShowAdPlacementContent ad = null;
                ad = Monetization.GetPlacementContent("video") as ShowAdPlacementContent;
                if (ad != null)
                {
                    ad.Show();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (Monetization.IsReady("rewardedVideo"))
            {
                ShowAdPlacementContent ad = null;
                ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
                if (ad != null)
                {
                    ad.Show();
                }
            }
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipEnigme4 : MonoBehaviour, Interface_TL_Events
{
    public float DebutEventTL = 30;
    public float DureeEventTL = 1;

    public void stop_TL_Event()
    {
        Destroy(this);
    }

    public float getDuration_TL_Event()
    {
        return DureeEventTL;
    }

    public float getStartTime_TL_Event()
    {
        return DebutEventTL;
    }
    public float getStopTime_TL_Event()
    {
        return DebutEventTL + DureeEventTL;
    }


    public bool isPausable_TL_Event()
    {
        return false;
    }
    public bool isPerdiodic_TL_Event(out float period)
    {
        period = 0.0f;
        return false;
    }

    public bool isRandomizable_TL_Event()
    {
        return false;
    }


    public void pause_TL_Event()
    {
        return; 
    }

    public void randomize_TL_Event()
    {
        return; 
    }

    public void restart_TL_Event()
    {
        return; 
    }

    public void start_TL_Event()
    {
        _MGR_UI.Instance.ShowPopUp("La couleur de l'épée vous guidera peut-être...");
    }

    public void TL_ChronoArrete()
    {
        return; 
    }

    public void TL_ChronoDemarre()
    {
        return; 
    }

    public void TL_ChronoEnPause()
    {
        return; 
    }
    public void TL_ChronoReprise()
    {
        return; 
    }
}

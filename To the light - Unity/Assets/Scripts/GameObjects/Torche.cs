﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torche : Ressource
{
    [SerializeField]
    private string m_name = "Lampe torche";
    public override string Name
    {
        get { return m_name; }
        set { m_name = value; }
    }

    [SerializeField]
    private string m_description = "Vous aidera à y voir plus clair";
    public override string Descrition
    {
        get { return m_description; }
        set { m_description = value; }
    }

    public override uint unitNumber
    {
        get { return 1; }
        set 
        {
            throw new System.Exception("Player can't have more than 1 lamp");
        }
    }

    public override uint GetPickedNumber() { return 1; }

    public override void Add(uint num = 1)
    {
        throw new System.Exception("Player can't have more than 1 lamp");
    }


    private bool m_isTurnedOn = false;
    public bool IsTurnedOn
    {
        get { return m_isTurnedOn; }
        set 
        {
            m_isTurnedOn = value;
            m_collider.enabled = !m_isTurnedOn; // Pas besoin du collider quand la lampe se déplace avec l'utilisateur
            m_light.enabled = m_isTurnedOn;
        }
    }

    //private Camera m_playerCamera = new Camera();
    private Collider m_collider;
    private Light m_light;

    void Start()
    {
        base.Start();

        m_collider = GetComponent<Collider>();
        m_light = GetComponentInChildren<Light>();
        //m_playerCamera = _MGR_GamePlay.Instance.player.GetComponentInChildren<Camera>();
    }

    //void Update()
    //{
    //    if (IsTurnedOn)
    //    {
    //        Vector3 torcheRotation = gameObject.transform.localRotation.eulerAngles;
    //        torcheRotation.y = Input.GetAxis("Mouse Y");
    //        gameObject.transform.localRotation = Quaternion.Euler(torcheRotation);
    //    }
    //}

    protected override void PickAction()
    {
        _MGR_Ressources.Instance.AddRessource(this);
        IsTurnedOn = true;

        //gameObject.transform.parent = _MGR_GamePlay.Instance.player.transform;
        gameObject.transform.parent = _MGR_GamePlay.Instance.player.GetComponentInChildren<Camera>().transform;
        //gameObject.transform.localPosition = new Vector3(1, 1.6f, 1.5f);
        gameObject.transform.localPosition = new Vector3(1, -0.6f, 1.5f);
        gameObject.transform.localRotation = Quaternion.Euler(0, 90, 0);
    }


}

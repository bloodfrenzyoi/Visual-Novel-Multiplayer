﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonNetworkManager : Photon.MonoBehaviour {

    [SerializeField]
    private Text connectText; 

	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings("0.1");
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

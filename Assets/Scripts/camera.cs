using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{
	private Renderer m_Renderer;
	private Texture m_MainTexture;
	
	// Use this for initialization
	void Start ()
	{
		m_MainTexture = Resources.Load<Texture>("images/tohu");
		//Fetch the Renderer from the GameObject
		m_Renderer = GetComponent<Renderer> ();

		//Make sure to enable the Keywords
		m_Renderer.material.EnableKeyword ("_NORMALMAP");
		m_Renderer.material.EnableKeyword ("_METALLICGLOSSMAP");

		//Set the Texture you assign in the Inspector as the main texture (Or Albedo)
		m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

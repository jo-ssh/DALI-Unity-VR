using UnityEngine;
using System.Collections;

public class SkyFogControl : MonoBehaviour {

	public float skyStep = 0.0001f;
	float skyBlend = 0.0f;
	int skySign = 1;

	public float fogStep = 0.001f;
	float fogBlend;
	int fogSign = 1;


	// Use this for initialization
	void Start () {
		RenderSettings.skybox.SetColor("_FogColor", RenderSettings.fogColor);
	}
	
	// Update is called once per frame
	void Update () {


		//SKY STUFF
		skyBlend += skyStep * skySign;

		if (skyBlend >= 1.00f) {
			skyBlend = 1.00f;
			skySign = -1;
		}
		else if(skyBlend <= 0.00f) {
			skyBlend = 0.00f;
			skySign = 1;
		}

		RenderSettings.skybox.SetFloat("_Blend", skyBlend);

		//FOG STUFF
		fogBlend += fogStep * fogSign;

		if (fogBlend >= 1.00f) {
			fogBlend = 1.00f;
			fogSign = -1;
		}
		else if(fogBlend <= 0.00f) {
			fogBlend = 0.00f;
			fogSign = 1;
		}

		RenderSettings.skybox.SetFloat("_Fog", fogBlend);
	}
}

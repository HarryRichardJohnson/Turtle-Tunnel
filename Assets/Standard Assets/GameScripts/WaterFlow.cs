// Water Flow 

#region Namespaces
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

#endregion

public class WaterFlow : MonoBehaviour
{

	#region Variables

	// Water Simple

	float m_Water_VMoveSpeed;
	float m_WaterOriginal_VMoveSpeed;

	// Water game objects
	public GameObject m_Water;

	#endregion

	#region MonoBehaviour

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.

	void Start()
	{

		// Get information from Simple water's material.
		m_WaterOriginal_VMoveSpeed = m_Water.GetComponent<Renderer>().material.GetFloat("_MoveSpeedV");
		m_Water_VMoveSpeed = m_WaterOriginal_VMoveSpeed;

		SetVSpeed(-10f);
	}

	// Update is called every frame, if the MonoBehaviour is enabled.
	void Update()
	{
	}

	#endregion // MonoBehaviour

	// V speed
	void SetVSpeed(float value)
	{
		m_Water_VMoveSpeed = value;
		m_Water.GetComponent<Renderer>().material.SetFloat("_MoveSpeedV", m_Water_VMoveSpeed);
	}


}

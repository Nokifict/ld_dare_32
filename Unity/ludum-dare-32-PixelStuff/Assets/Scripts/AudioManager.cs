using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
	
	GameObject m_backgroundGameObject;
	AudioSource m_backgroundAudioSource;

	public void Play(string clipname)
	{
		//Create an empty game object
		GameObject go = new GameObject ("Audio_" +  clipname);

		//Load clip from ressources folder
		AudioClip newClip =  Instantiate(Resources.Load ("Sounds/"+clipname, typeof(AudioClip))) as AudioClip;
	
		//Add and bind an audio source
		AudioSource source = go.AddComponent<AudioSource>();
		source.clip = newClip;
	
		//Play and destroy the component
		source.Play();
		Destroy (go, newClip.length);
		return;
	}

	public void startAudioBackground() {
		m_backgroundAudioSource.Play();
	}

	public void stopAudioBackground() {
		m_backgroundAudioSource.Stop();
	}

	// Use this for initialization
	void Start () {
		//Create an empty game object
		m_backgroundGameObject = new GameObject ("Audio_Background");
		//Load clip from ressources folder
		AudioClip bgClip =  Instantiate(Resources.Load ("Sounds/BackgroundMusic", typeof(AudioClip))) as AudioClip;
		
		//Add and bind an audio source
		m_backgroundAudioSource = m_backgroundGameObject.AddComponent<AudioSource>();
		m_backgroundAudioSource.clip = bgClip;
		m_backgroundAudioSource.loop = true;
		m_backgroundAudioSource.volume = 0.2f;
		//Play and destroy the component
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
	
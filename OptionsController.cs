using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider, diffSlider;
	public LevelManager levelManager;
	
	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		//Debug.Log (musicManager);
		
		diffSlider.value = PlayerPrefsManager.GetDifficulty();
	
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.ChangeVolume (volumeSlider.value);
	
	}
	
	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		levelManager.LoadLevel ("01a_Start");
		
		PlayerPrefsManager.SetDifficulty (diffSlider.value);
	}
	
	public void SetDefaults(){
		volumeSlider.value = 0.8f;
		diffSlider.value = 2;
	}
}

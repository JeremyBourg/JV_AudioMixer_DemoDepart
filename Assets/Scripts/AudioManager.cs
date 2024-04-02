using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    [SerializeField]
    private AudioMixer audioMixer;

    [SerializeField]
    private Slider sliderMusique;
    [SerializeField]
    private Slider sliderFX;


    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void AjusteMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", ConvertToLogarithm(volume));
    }

    public void AjusteFX(float volume){
        audioMixer.SetFloat("VolumeFX", ConvertToLogarithm(volume));
        audioSource.Play();
    }


    private float ConvertToLogarithm(float volume){
        return Mathf.Log10(volume) * 20;
    }
    


    
}

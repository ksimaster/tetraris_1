using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMusic : MonoBehaviour
{
    [SerializeField] private AudioClip defaultClip;
    [SerializeField] private AudioClip clipFor10Lvl;
    [SerializeField] private string nameScene;
    private string currentScene;
   

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name != currentScene)
        {
            ChangeMusicFon(defaultClip, clipFor10Lvl, nameScene);
            currentScene = SceneManager.GetActiveScene().name;
            Debug.Log("Выполнилось");
        }
        
    }
    public void ChangeMusicFon(AudioClip defaultAudioClip, AudioClip changeAudioClip, string nameSceneForChange)
    {
        if (SceneManager.GetActiveScene().name == nameSceneForChange)
        {

            gameObject.GetComponent<AudioSource>().clip = changeAudioClip;
            if (!(gameObject.GetComponent<AudioSource>().isPlaying))
            {
                gameObject.GetComponent<AudioSource>().Play();
            }

        }
        else
        {
            gameObject.GetComponent<AudioSource>().clip = defaultAudioClip;
            if (!(gameObject.GetComponent<AudioSource>().isPlaying))
            {
                gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }
}

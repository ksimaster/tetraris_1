using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.N.Fridman.BackgroundInstanceController.Scripts
{
    public class BackgroundInstanceControllerComponent : MonoBehaviour
    {
        [Header("Tags")]
        [Tooltip("Unique Object Tag")]
        [SerializeField] private string createdTag;
        [SerializeField] private AudioClip defaultClip;
        [SerializeField] private AudioClip clipFor10Lvl;
       


        private void Awake()
        {
            GameObject obj = GameObject.FindWithTag(this.createdTag);
            if (obj != null)
            {
                Destroy(this.gameObject);
            }
            else
            {
                this.gameObject.tag = this.createdTag;
                DontDestroyOnLoad(this.gameObject);
            }
            
            Debug.Log(SceneManager.GetActiveScene().name.ToString());
      
            if (SceneManager.GetActiveScene().name == "MainMenu"){
                gameObject.GetComponent<AudioSource>().GetComponent<AudioClip>().Equals(clipFor10Lvl);
            }
            else
            {
                gameObject.GetComponent<AudioSource>().GetComponent<AudioClip>().Equals(defaultClip);
            }
         }   
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers Instance;

    [SerializeField] private InputManager inputManager;
    [SerializeField] private SceneManager sceneManager;
    [SerializeField] private SoundManager soundManager;

    public InputManager InputManager { get => inputManager; }
    public SceneManager SceneManager { get => sceneManager; }
    public SoundManager SoundManager { get => soundManager; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
using Cysharp.Threading.Tasks;
using UnityEngine;
using System;
    public class LevelManager : MonoBehaviour
    {
        public GameObject InstantiatedObject;
        public GameObject Level1Prefab;
        public GameManager gm;
        
        private void Start()
        {
            CreateLevel();
        }
        
        public void CreateLevel()
        {
            InstantiatedObject = Instantiate(Level1Prefab, Vector3.zero, Quaternion.identity);
        }

        public async UniTaskVoid RestartLevel()
        {
            if (InstantiatedObject != null)
            {
                Destroy(InstantiatedObject);
                await UniTask.Delay(TimeSpan.FromSeconds(1));
                InstantiatedObject = null;
                CreateLevel();
            }
        }
        
    }

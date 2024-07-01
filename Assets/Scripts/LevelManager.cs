using Cysharp.Threading.Tasks;
using UnityEngine;
using System;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
    {
        public List<LevelScript> _levels = new();
        private GameObject InstantiatedObject;
        public int LevelIndex = 0;
        
        private void Start()
        {
            CreateLevel();
        }
        
        public void CreateLevel()
        {
            InstantiatedObject = Instantiate(_levels[LevelIndex].gameObject, Vector3.zero, Quaternion.identity);
        }

        public async UniTaskVoid RestartLevel()
        {
            if (InstantiatedObject != null)
            {
                Destroy(InstantiatedObject);
                await UniTask.Delay(TimeSpan.FromSeconds(0.2));
                InstantiatedObject = null;
                CreateLevel();
            }
        }
        
    }

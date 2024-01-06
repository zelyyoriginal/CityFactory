using System;
using UnityEngine;



    public class MovebleProduct : MonoBehaviour, IProduct
    {
        public string _name { get; set; } = "TRANSPORT";
        public Material _material { get; set; }
        public void init(GameObject obj)
        {
            gameObject.name = _name;
            gameObject.AddComponent<Rigidbody>().velocity = Vector3.forward*10;
        }

        private void Start()
        {
            Destroy(gameObject,12);
        }
    }

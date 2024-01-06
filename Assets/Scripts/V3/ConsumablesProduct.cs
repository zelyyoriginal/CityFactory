using System;
using UnityEngine;


    public class ConsumablesProduct : MonoBehaviour, IProduct
    {
        public string _name { get; set; } = "CONSUMABLES";
        public Material _material { get; set; }
        private  Vector3 _ofset = new Vector3(-2,6,4);
        public void init(GameObject obj)
        {
            gameObject.AddComponent<Rigidbody>();
            gameObject.transform.position += _ofset;
        }

        private void Start()
        {
            Destroy(gameObject,12);
        }
    }

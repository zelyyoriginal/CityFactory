using System;
using Unity.Mathematics;
using UnityEngine;

namespace DefaultNamespace
{
    public class MouseKlicer : MonoBehaviour
    {
        private AbstractFactory _factory;


        private void Awake()
        {
            _factory = new V1Factory();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity) )
                {
                     _factory = (hitInfo.transform.GetComponent<AbstractFactory>())
                                   ? hitInfo.transform.GetComponent<AbstractFactory>()
                                   : new V1Factory();
                    
                     _factory.GetProduct(hitInfo.point);
                }
                
            }
        }
    }

    public class V1Factory : AbstractFactory
    {
        public GameObject prefab;
        
        private IProduct[] _city = {
                                    new PeacefulCity(), 
                                    new MilitaryCity(),
                                    };
        

        public override void GetProduct(Vector3 position)
        {
            prefab = Resources.Load("V1_city") as GameObject;
            Vector3 pos = new Vector3(position.x,2,position.z);
            GameObject i = Instantiate(prefab,pos,quaternion.identity);
           _city[UnityEngine.Random.Range(0,_city.Length)].init(i);
        }
    }
}
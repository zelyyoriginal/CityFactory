using UnityEngine;


public class MilitaryCityFactory : AbstractFactory
    {
        public GameObject _WorkshopPrefab;
        private IProduct[] _workshops; 


        public void Start()
        {
            _WorkshopPrefab = Resources.Load("V2_workShop") as GameObject;
            _workshops = new IProduct[]
            {   new Workshop("Tanks",     "V2/V2_Milittary_Tank", true), 
                new Workshop("WEAPON",    "V2/V2_Milittary_Weapon", false), 
                new Workshop("HELICOPTER","V2/V2_Milittary_Helicopter", true), 

            };


        }

        public override void GetProduct(Vector3 position)
        {
            Vector3 pos = new Vector3(GetRandomOfset(position.x),Yofset,GetRandomOfset(position.z));
            GameObject curent = Instantiate(_WorkshopPrefab, pos, Quaternion.identity);
            _workshops[Random.Range(0,_workshops.Length)].init(curent);
        }
        
        private float GetRandomOfset(float vector)

        {
            float ofaset = Random.Range(-12, -4);
            int nigativ = Random.Range(-1, 1) >= 0 ? 1 : -1; 
            return vector + ofaset * nigativ;

        }
    }

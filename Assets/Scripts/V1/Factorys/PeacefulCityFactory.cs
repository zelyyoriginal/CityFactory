using UnityEngine;


    public class PeacefulCityFactory: AbstractFactory
    {

        private GameObject _workshopPrefab;
        private IProduct[] _workshops;
        
        void Start()
        {
            _workshopPrefab = Resources.Load("V2_workShop") as GameObject;
            _workshops = new IProduct[]
            {
                new Workshop("Nisan", "V2/V2_Peaceful_Car",true),
                new Workshop("KFC", "V2/V2_Peaceful_Food", false),
                new Workshop("LEGO", "V2/V2_Peaceful_Toy", false),
            };

        }
        
            
        public override void GetProduct(Vector3 position)
        {  
            Vector3 pos = new Vector3(GetRandomOfset(position.x),
                                      Yofset,
                                      GetRandomOfset(position.z));


          GameObject curent =  Instantiate(_workshopPrefab, pos, Quaternion.identity);
          _workshops[Random.Range(0,_workshops.Length)].init(curent);
           
           
        }
    
        private float GetRandomOfset(float vector)

        {
           float ofaset = Random.Range(-12, -4);
           int nigativ = Random.Range(-1, 1) >= 0 ? 1 : -1; 
           return vector + ofaset * nigativ;

        }
    }
    
    

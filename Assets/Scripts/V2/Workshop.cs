using UnityEngine;

public class Workshop : IProduct
    {
        public string _name { get; set; } = "WorkShop";
        public Material _material { get; set; }
        private bool ismoveble;

        public Workshop(string name, string pathToMaterial,bool IsMoveProd)
        {
            _name = name + " " + _name;
            _material = Resources.Load(pathToMaterial) as Material;
            ismoveble= IsMoveProd;
        }

        public void init(GameObject obj)
        {
            obj.GetComponent<Renderer>().material = _material;
            obj.name = _name;
            if(ismoveble) obj.AddComponent<MovebleProdFactory>();
            else
            {
                obj.AddComponent<ProdFactory>();
            }



        }
        
        
        
    }

    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    public class Test
    {
        public Test()
        {
            //stardart
            this.MyProperty = new List<int>();
        }

        private List<int> MyProperty { get; set; } 

        public void AddItemToMyProperty(int obj)
        {
            if(this.MyProperty == null)
            {
                this.MyProperty = new List<int>();
            }
            this.MyProperty.Add(obj);
        }

        public int ReturnItemFromMyProperty(int i)
        {
            if (this.MyProperty == null)
            {
                this.MyProperty = new List<int>();
            }
            return this.MyProperty[i];
        }
        //vij sq
        //principno sa public Property-tata ti
        //private sa ti field-ovete na klasa
        //prosto takava e ideqta - dabe
        
        //problema tuka e 4e navsqkyde trqbva da se pazi6 da ti e inicializiran spisyka
        //ina4e se pravi taka
        public List<int> MyProperty2
        {
            get
            {
                if(this.myProperty2 == null)
                {
                    this.myProperty2 = new List<int>();
                }
                return this.myProperty2;
            }
            set
            {
                this.myProperty2 = value;
            }
        }
        private List<int> myProperty2;
        //i sega mahav proverkite v dvamata metoda i si izrod 
        //;) - :D sq nisht ne razbrah sq q v program dobavi edin item
        // da vidq kak stava
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.Collections
{
    class Coffee
    {
        private int strength;
        private string bean;
        private string country;

        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }

        public string Bean
        {
            get
            {
                return bean;
            }
            set
            {
                bean = value;
            }
        }

        public string CountryOfOrigin
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public Coffee(int StrengthType, string BeanType, string CountryType)
        {
            this.Strength = StrengthType;
            this.Bean = BeanType;
            this.CountryOfOrigin = CountryType;
        }
    }
}

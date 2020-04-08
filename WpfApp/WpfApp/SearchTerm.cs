﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class SearchTerm
    {
        /// <summary>
        /// Various getters and setters
        /// </summary>
        private string owner;
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        private string breed;
        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
            }
        }
        private string animalName;
        public string AnimalName
        {
            get
            {
                return this.animalName;
            }
            set
            {
                this.animalName = value;
            }
        }
        private string code;
        public string Code
        {
            get
            {
                return this.code;
            }
            set
            {
                this.code = value;
            }
        }
        private string canNum;
        public string CanNum
        {
            get
            {
                return this.canNum;
            }
            set
            {
                this.canNum = value;
            }
        }
        private string town;
        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }
        private string state;
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }
        /*private string date;
        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }*/
        /// <summary>
        /// Constructor for the object, taking in search fields from the Search Window
        /// </summary>
        /// <param name="canNum">The cane number of the animal</param>
        /// <param name="code">The unique id of the animal</param>
        /// <param name="animalName">The name of the animal</param>
        /// <param name="breed">A breed of animal</param>
        /// <param name="owner">The owner of an animal</param>
        /// <param name="town">The town of origin</param>
        /// <param name="state">The state of origin</param>
        public SearchTerm(string canNum, string code, string animalName, string breed, string owner, string town, string state)
        {
            this.CanNum = canNum;
            this.Code = code;
            this.AnimalName = animalName;
            this.Breed = breed;
            this.Owner = owner;
            this.Town = town;
            this.State = state;
            //this.Date = date;
        }
    }
}

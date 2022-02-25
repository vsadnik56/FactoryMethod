using FitnessClub.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Factories
{
    internal class PersonalTrainingMembershipFactory : MemberyshipFactory
    {
        private readonly decimal _price;
        private readonly string _description;
        public PersonalTrainingMembershipFactory (decimal price, string description)
        {
            _price = price;
            _description = description;
        }
        public override IMembership GetMembership()
        {
            PersonalTrainingMembership personalTrainingMembershipFactoryMembership = new PersonalTrainingMembership(_price)
            {
                Description = _description
            };
            return personalTrainingMembershipFactoryMembership;
            ;
        }
    }
}

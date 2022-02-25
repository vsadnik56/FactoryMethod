using FitnessClub.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Factories
{
    internal class GymMembershipFactory:MemberyshipFactory
    {
        private readonly decimal _price;
        private readonly string _description;
        public GymMembershipFactory(decimal price,string description)
        {
            _price = price;
            _description = description;
        }
        public override IMembership GetMembership()
        {
            GymMembership gymMembership = new GymMembership(_price)
            {
                Description = _description
            };
            return gymMembership;
        }
    }
}

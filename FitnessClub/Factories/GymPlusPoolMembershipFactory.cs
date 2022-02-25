using FitnessClub.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Factories
{
    internal class GymPlusPoolMembershipFactory: MemberyshipFactory
    {
        private readonly decimal _price;
        private readonly string _description;
        public GymPlusPoolMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }
        public override IMembership GetMembership()
        {
            GymPlusPoolMembership gymPlusPoolMembership = new GymPlusPoolMembership(_price)
            {
                Description = _description
            };
            return gymPlusPoolMembership;
;
        }
    }
}

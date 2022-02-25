using FitnessClub.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Factories
{
    internal abstract class MemberyshipFactory
    {
        public abstract IMembership GetMembership();
    }
}

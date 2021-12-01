using FixtureProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureProject.DAL
{
    public interface IFixtureDal
    {
        void AddFixture(Fixture fixture);
        List<Fixture> GetFixtures();
        List<Fixture> GetFixture(string serailno);
        void UpdateFixture(string serailno);
        Fixture GetFixtureBySerailNo(string serailno);
        Fixture GetFixtureById(int Id);
        void UpdateFixture(Fixture fixture);
        void DeleteFixture(Fixture fixture);
    }
}

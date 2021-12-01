using FixtureProject.Contexts;
using FixtureProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureProject.DAL
{
    public class FixtureDal : IFixtureDal
    {
        public void AddFixture(Fixture fixture)
        {
            using (var context = new FixtureContext())
            {
                context.Fixtures.Add(fixture);
                context.SaveChanges();
            }
        }
        public List<Fixture> GetFixtures()
        {
            List<Fixture> list;
            using (var context = new FixtureContext())
            {
              list = context.Fixtures.Select(f => f).ToList();
            }
            return list;
        }
        public void UpdateFixture(string serailno)
        {
            using (var context = new FixtureContext())
            {
                var fixture = context.Fixtures.Where(f => f.SerialNo == serailno).FirstOrDefault();
                if (fixture != null)
                {
                    fixture.UseCount += 1;
                }
                context.SaveChanges();
            }
        }
        public Fixture GetFixtureBySerailNo(string serailno)
        {
            using (var context = new FixtureContext())
            {
                var fixture = context.Fixtures.Where(f => f.SerialNo == serailno).FirstOrDefault();
                return fixture;
            }
        }
        public Fixture GetFixtureById(int Id)
        {
            using (var context = new FixtureContext())
            {
                var fixture = context.Fixtures.Where(f => f.Id == Id).FirstOrDefault();
                return fixture;
            }
        }

        public void UpdateFixture(Fixture fixture)
        {
            using (var context = new FixtureContext())
            {
                var _fixture = context.Fixtures.Where(f =>f.Id == fixture.Id && f.SerialNo == fixture.SerialNo ).FirstOrDefault();
                _fixture.FixtureName = fixture.FixtureName;
                _fixture.CeilingCount = fixture.CeilingCount;
                _fixture.CycleCount = fixture.CycleCount;
                context.SaveChanges();
            }
        }

        public void DeleteFixture(Fixture fixture)
        {
            using (var context = new FixtureContext())
            {
                context.Fixtures.Attach(fixture);
                context.Fixtures.Remove(fixture);
                context.SaveChanges();
            }
        }

        public List<Fixture> GetFixture(string serailno)
        {
            using (var context = new FixtureContext())
            {
                var fixture = context.Fixtures.Where(f => f.SerialNo == serailno).ToList();
                return fixture;
            }
        }
    }
}

using FixtureProject.DAL;
using FixtureProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixtureProject.Controls
{
    public class FixtureService
    {
        private readonly IFixtureDal fixtureDal;

        public FixtureService(IFixtureDal _fixtureDal)
        {
            this.fixtureDal = _fixtureDal;
        }
        public void AddFixture(Fixture fixture)
        {
            this.fixtureDal.AddFixture(fixture);
        }
        public Fixture ScanFixture(string serialno)
        {
            return this.fixtureDal.GetFixtureBySerailNo(serialno);
       
        }
        public Fixture ScanFixture(int id)
        {
           return this.fixtureDal.GetFixtureById(id);
        }
        public List<Fixture> SearchFixtures()
        {
            return this.fixtureDal.GetFixtures();
        }
        public dynamic SearchFixtures(string serialno)
        {
            var fixtures = (from fixs in this.fixtureDal.GetFixture(serialno)
                            select new
                            {
                                ID = fixs.Id,
                                治具标签 = fixs.SerialNo,
                                治具名 = fixs.FixtureName,
                                投入日期 = fixs.InvestmentDate,
                                使用上限 = fixs.CeilingCount,
                                保养周期次数 = fixs.CycleCount
                            }
                            ).ToList(); ;
            return fixtures;
        }
        public dynamic InqueryFixtures(string serialno)
        {
            var fixtures = (
                    from fixs in 
                        (String.IsNullOrEmpty(serialno) ? this.fixtureDal.GetFixtures() : this.fixtureDal.GetFixtures().Where(f => f.SerialNo == serialno))
                    select new
                    {
                        治具标签 = fixs.SerialNo,
                        治具名 = fixs.FixtureName,
                        使用次数 = fixs.UseCount,
                        投入日期 = fixs.InvestmentDate,
                        使用上限 = fixs.CeilingCount,
                        保养周期次数 = fixs.CycleCount
                    }
                ).ToList();
            return fixtures;
        }
        public void UpdateFixture(Fixture fixture)
        {
            this.fixtureDal.UpdateFixture(fixture);
        }
        public void DeleteFixture(Fixture fixture)
        {
            this.fixtureDal.DeleteFixture(fixture);
        }
    }
}

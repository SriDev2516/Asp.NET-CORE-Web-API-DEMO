using Parky.API.Data;
using Parky.API.Models;
using Parky.API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parky.API.Repository
{
    public class NationalParkRepository : INationalParkRepository
    {
        private readonly ApplicationDBContext _db;

        public NationalParkRepository(ApplicationDBContext db)
        {
            _db = db;
        }

        public bool CreateNationalPark(NationalPark nationalPark)
        {
            _db.Add(nationalPark);
            return Save();
        }

        public bool DeleteNationalPark(NationalPark nationalPark)
        {
            _db.Remove(nationalPark);
            return Save();
        }

        public NationalPark GetNationalPark(int nationalparkID)
        {
            return _db.NationalParks.FirstOrDefault(a => a.Id == nationalparkID);
        }
        

        public ICollection<NationalPark> GetNationalParks()
        {
            return _db.NationalParks.OrderBy(a=>a.Name).ToList();
        }

        public bool NationalParkExists(string name)
        {
            bool exists = _db.NationalParks.Any(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
            return exists;

        }

        public bool NationalParkExists(int id)
        {
            bool exists = _db.NationalParks.Any(x => x.Id == id);
            return exists;
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true: false;
        }

        public bool UpdateNationalPark(NationalPark nationalPark)
        {
            _db.NationalParks.Update(nationalPark);
            return Save();
        }
    }
}

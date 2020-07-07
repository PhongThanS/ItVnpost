using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using ItVnpost.DataAccess.Data;

namespace ItVnpost.Repository
{
    public class SolutionPictureRepository :  Repository<SolutionPicture>, ISolutionPictureRepository
    {
        private readonly ApplicationDbContext _db;
        public SolutionPictureRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }
        public void Remove(object id)
        {
            _db.Remove(_db.SolutionPictures.Find(id));
        }
    }
}

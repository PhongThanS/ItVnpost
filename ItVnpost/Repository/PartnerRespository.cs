using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
	public class PartnerRespository : Repository<Partner>, IPartnerRespository
	{

		private readonly ApplicationDbContext _db;
		public PartnerRespository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Update(Partner partners)
		{
				var newsold = _db.Partners.Find(partners.Id);
				newsold.PartnerTypeId = partners.PartnerTypeId;
				newsold.Image = partners.Image;
				newsold.Name = partners.Name;
				newsold.IsShow = partners.IsShow;
				newsold.Order = partners.Order;
				newsold.UserIdModified = partners.UserIdModified;
				newsold.DateModified = DateTime.Now;
		}
		public void Remove(object id)
		{
			var ob = _db.Partners.Find(id);
			ob.IsHidden = true;
		}
	}
}

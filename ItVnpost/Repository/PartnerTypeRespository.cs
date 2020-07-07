using ItVnpost.Repository.IRepository;
using ItVnpost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ItVnpost.DataAccess.Data;
using System.Linq;

namespace ItVnpost.Repository
{
	public class PartnerTypeRespository : Repository<PartnerType>, IPartnerTypeRespository
	{

		private readonly ApplicationDbContext _db;
		public PartnerTypeRespository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Update(PartnerType partnertypes)
		{
			try
			{
				var newsold = _db.PartnerType.Find(partnertypes.Id);
				newsold.MenuId = partnertypes.MenuId;
				newsold.Name = partnertypes.Name;
				newsold.IsShowPage = partnertypes.IsShowPage;
				newsold.Order = partnertypes.Order;
				//newsold.ColorName = partnertypes.ColorName;
				//newsold.ColorSlider = partnertypes.ColorSlider;
				newsold.IsHidden = partnertypes.IsHidden;
				newsold.UserIdModified = partnertypes.UserIdModified;
				newsold.DateModified = partnertypes.DateModified;
				_db.Entry(newsold).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			}
			catch (Exception)
			{

				throw;
			}
		}
		public void Remove(object id)
		{
			var ob = _db.PartnerType.Find(id);
			ob.IsHidden = true;
			_db.Entry(ob).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
		}
	}
}

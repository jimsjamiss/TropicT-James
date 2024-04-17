using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TropicTrail.Utils;

namespace TropicTrail.Repository
{
    public class TourTypeManager
    {
        private BaseRepository<TourType> _tourtype;
        private UserManager _userMgr;

        public TourTypeManager()
        {
            _tourtype = new BaseRepository<TourType>();
            _userMgr = new UserManager();
        }
        public List<TourType> ListTourType(String username)
        {
            var user = _userMgr.GetUserByUsername(username);
            return _tourtype._table.Where(m => m.userId == user.userId).ToList();
        }

        public TourType GetBrandById(int? id)
        {
            return _tourtype.Get(id);
        }
        public ErrorCode CreateBrand(TourType tourType, ref String err)
        {
            return _tourtype.Create(tourType, out err);
        }
        public ErrorCode UpdateBrand(TourType tourType, ref String err)
        {
            return _tourtype.Update(tourType.tourId, tourType, out err);
        }
        public ErrorCode DeleteTourType(int? id, ref String err)
        {
            return _tourtype.Delete(id, out err);
        }
    }
}
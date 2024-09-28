using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using General.DataDto.Base;
using General.Services;
using Microsoft.EntityFrameworkCore;
using General.DataAccess.Interface;
using CrawlContent.DataAccess.Entities;

namespace General.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommonController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMyTypedClientServices _client;
        private ICommonRepository<KhachHangMoi> _khachHangMoi { get; set; }
        private ICommonRepository<GiaoDichMoi> _giaoDichMoi { get; set; }
        public CommonController(IMapper mapper, IMyTypedClientServices client, ICommonRepository<KhachHangMoi> khachHangMoi, ICommonRepository<GiaoDichMoi> giaoDichMoi)
        {
            _mapper = mapper;
            _client = client;
            _khachHangMoi = khachHangMoi;
            _giaoDichMoi = giaoDichMoi;
        }

        [HttpGet("dashboard")]
        public ResponseBase GetDashBoard()
        {
            var data = _khachHangMoi.FindAll()
                                        //.Include(x => x.GiaoDichMois)
                                        .Select(x => new {Ten = x.Tenkh, Tong = x.GiaoDichMois.Sum(c => c.Giacuoi)})
                                        .ToList();
            var data2 = _giaoDichMoi.FindAll(x => x.Idgd == 3).Select(x => new Testets
            {
                Gia = x.Giacuoi,
                KhacHang = x.IdkhNavigation.Tenkh
            }).FirstOrDefault();
            return new ResponseBase { };
        }
    }

    public class Testets
    {
        public decimal Gia { get; set; }
        public string KhacHang { get; set; }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TheCodeCamp.Models;

namespace TheCodeCamp.Data
{
    public class CampMappingProfile : Profile
    {
        public CampMappingProfile()
        {
            CreateMap<Camp, CampModel>()
                .ForMember(c => c.Venue, opt => opt.MapFrom(m => m.Location.VenueName));
            CreateMap<Talk, TalkModel>()
                .ForMember(c => c.TalkId, opt => opt.MapFrom(m => m.TalkId));
            CreateMap<Speaker, SpeakerModel>()
                .ForMember(c => c.SpeakerId, opt => opt.MapFrom(m => m.SpeakerId));
        }
    }
}

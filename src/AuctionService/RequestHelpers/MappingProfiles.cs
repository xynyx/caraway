using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Auction =>  Auction DTO
        // Want to map Item as well (IncludeMembers)
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        // Need to tell it to go from Item to Auction DTO as well (other direction)
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>().ForMember(destination => destination.Item, o => o.MapFrom(source => source));
        CreateMap<CreateAuctionDto, Item>();
    }
}

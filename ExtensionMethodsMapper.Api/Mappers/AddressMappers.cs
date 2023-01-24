using ExtensionMethodsMapper.Models;
using ExtensionMethodsMapper.Shared;

namespace ExtensionMethodsMapper.Api.Mappers;

public static class AddressMappers
{
    public static AddressDto ToAddressDto(this Address address)
    {
        return new AddressDto
        {
            AddressLine1 = address.AddressLine1,
            AddressLine2 = address.AddressLine2,
            City = address.City,
            Country = address.Country,
            Id = address.Id,
            State = address.State,
            ZipCode = address.ZipCode,
        };
    }
}